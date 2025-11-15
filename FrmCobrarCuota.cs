using ClubDeportivo.Datos;
using ClubDeportivo.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FrmCobrarCuota : Form
    {
        public FrmCobrarCuota()
        {
            InitializeComponent();
        }

        private void FrmCobrarCuota_Load(object sender, EventArgs e)
        {
            cboMedioPago.Items.Add("EFECTIVO");
            cboMedioPago.Items.Add("TARJETA");

            cboCuotas.Enabled = false;

            lblTotal.Text = "$0";
        }
        // Buscar socio por dni
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un DNI.");
                return;
            }

            int dni = Convert.ToInt32(txtDni.Text.Trim());
            CuotaDatos cd = new CuotaDatos();

            DataTable dt = cd.ListarCuotaPendiente(dni);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("El socio no tiene cuota pendiente o no existe.");
                dgvSocio.DataSource = null;
                return;
            }

            dgvSocio.DataSource = dt;

            dgvSocio.Columns["idSocio"].Visible = false;
            dgvSocio.Columns["idCuota"].Visible = false;

            // Mostrar monto base en label
            decimal monto = Convert.ToDecimal(dt.Rows[0]["monto"]);
            lblTotal.Text = "$" + monto.ToString("N2");
            txtMonto.Text = monto.ToString();

        }


        // EVENTO: Cambio de medio de pago, Si es Efectivo = cuotas deshabilitado, Si es Tarjeta = habilitar cuotas(1, 3, 6)
        private void cboMedioPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMedioPago.SelectedItem == null)
                return;

            if (cboMedioPago.SelectedItem.ToString() == "TARJETA")
            {
                cboCuotas.Enabled = true;
                cboCuotas.Items.Clear();
                cboCuotas.Items.Add("1");
                cboCuotas.Items.Add("3");
                cboCuotas.Items.Add("6");
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }

            CalcularTotal();
        }
        // evento: cambiar cuotas (1, 3, 6)
        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        // Funcion calcula el monto total a cobrar
        private void CalcularTotal()
        {
            if (dgvSocio.Rows.Count == 0)
                return;

            decimal montoBase;

            if (!decimal.TryParse(txtMonto.Text, out montoBase))
            {
                MessageBox.Show("Ingrese un monto válido.");
                return;
            }
            decimal total = montoBase;

            if (cboMedioPago.SelectedItem != null &&
                cboMedioPago.SelectedItem.ToString() == "TARJETA" &&
                cboCuotas.SelectedIndex != -1)
            {
                int cuotas = Convert.ToInt32(cboCuotas.SelectedItem);

                if (cuotas == 3)
                    total = montoBase * 1.10m; // 10% recargo
                else if (cuotas == 6)
                    total = montoBase * 1.20m; // 20% recargo
            }

            lblTotal.Text = "$" + total.ToString("N2");

        }

        // Evento del boton pagar
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (dgvSocio.Rows.Count == 0)
            {
                MessageBox.Show("Debe buscar un socio primero.");
                return;
            }

            if (cboMedioPago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un medio de pago.");
                return;
            }

            string medio = cboMedioPago.SelectedItem.ToString();
            int cuotas = 1;

            if (medio == "TARJETA")
            {
                if (cboCuotas.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione la cantidad de cuotas.");
                    return;
                }

                cuotas = Convert.ToInt32(cboCuotas.SelectedItem);
            }

            int idSocio = Convert.ToInt32(dgvSocio.CurrentRow.Cells["idSocio"].Value);
            int idCuota = Convert.ToInt32(dgvSocio.CurrentRow.Cells["idCuota"].Value);

            // 🔹 Actualizar monto en BD
            decimal montoEditado = Convert.ToDecimal(dgvSocio.CurrentRow.Cells["monto"].Value);
            bool actualizado = CuotaDatos.ActualizarMonto(idCuota, montoEditado);

            if (!actualizado)
            {
                MessageBox.Show("Error al actualizar el monto de la cuota.");
                return;
            }

            // Total ya incluye recargos
            decimal total = decimal.Parse(
                lblTotal.Text.Replace("$", ""),
                System.Globalization.CultureInfo.GetCultureInfo("es-AR")
            );

            bool ok = CuotaDatos.CobrarCuota(idSocio, idCuota, total, medio, cuotas);

            if (ok)
            {
                MessageBox.Show("Pago registrado correctamente.");

                dgvSocio.CurrentRow.Cells["estado"].Value = "PAGADA";
                btnPagar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al registrar el pago.");
            }
        }


        //Evento del Boton volver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarCuota_Click(object sender, EventArgs e)
        {
            Socio socio = SocioDatos.BuscarPorDni(txtDni.Text);

            if (socio == null)
            {
                MessageBox.Show("El socio no existe.");
                return;
            }

            decimal monto = 5000; // ejemplo: cuota fija
            bool ok = CuotaDatos.GenerarCuota(socio.IdSocio, monto);

            if (ok)
                MessageBox.Show("Cuota generada correctamente.");
            else
                MessageBox.Show("Error al generar la cuota.");
        }

        //Actualizar el monto en la grilla
        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            if (dgvSocio.CurrentRow == null)
                return;

            decimal monto;

            // Validamos el número
            if (decimal.TryParse(txtMonto.Text.Replace(",", "."),
                                 System.Globalization.NumberStyles.Any,
                                 System.Globalization.CultureInfo.InvariantCulture,
                                 out monto))
            {
                // Se actualiza en la grilla
                dgvSocio.CurrentRow.Cells["monto"].Value = monto;

                // Recalcular el total
                CalcularTotal();
            }
        }

    }
}
