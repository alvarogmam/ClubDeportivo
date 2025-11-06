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
    public partial class FrmListadoSocios : Form
    {
        public FrmListadoSocios()
        {
            InitializeComponent();
        }

        private void FrmListadoSocios_Load(object sender, EventArgs e)
        {
            try
            {
                SocioDatos socioDatos = new SocioDatos();
                dgvSocios.DataSource = socioDatos.ListarSocios();

                dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvSocios.ScrollBars = ScrollBars.Both;
                dgvSocios.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SocioDatos socioDatos = new SocioDatos();
                dgvSocios.DataSource = socioDatos.ListarSocios();
                MessageBox.Show("Lista actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la lista de socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario de listado y regresa al menú principal
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            SocioDatos socioDatos = new SocioDatos();
            dgvSocios.DataSource = socioDatos.BuscarSocios(txtBuscar.Text.Trim());
        }


    }
}
