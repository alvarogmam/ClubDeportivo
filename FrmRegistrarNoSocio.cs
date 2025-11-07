using ClubDeportivo.Datos;
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
    public partial class FrmRegistrarNoSocio : Form
    {
        public FrmRegistrarNoSocio()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                NoSocioDatos datos = new NoSocioDatos();

                bool resultado = datos.RegistrarNoSocio(
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtDni.Text.Trim(),
                    txtMail.Text.Trim(),
                    Convert.ToDecimal(txtPagoDiario.Text)
                );

                if (resultado)
                {
                    MessageBox.Show("No Socio registrado exitosamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDni.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtPagoDiario.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPagoDiario.Text, out _))
            {
                MessageBox.Show("El monto debe ser numérico.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtMail.Clear();
            txtPagoDiario.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistrarNoSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
