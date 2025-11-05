using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo.Datos;

namespace ClubDeportivo
{
    public partial class FrmRegistrarSocio : Form
    {
        private MySqlConnection conexion;
        public FrmRegistrarSocio()
        {
            InitializeComponent();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacios
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtDNI.Text))
                {
                    MessageBox.Show("Por favor, complete los campos obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool aptoFisico = rbAptoSi.Checked;
                
                // Crear instancia de la capa de datos
                SocioDatos sociodatos = new SocioDatos();

                // Llamar al método de inserción
                sociodatos.RegistrarSocio(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtDNI.Text,
                    txtMail.Text,
                    aptoFisico
                );
                    MessageBox.Show("Socio registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo que limpia los campos del formulario registrar socio
        private void limpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtMail.Clear();
            rbAptoSi.Checked = false;
            rbAptoNo.Checked = false;
        }
        //Evento del boton volver(retorna al menu principal)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este formulario y vuelve al menú
        }
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistrarSocio_Load(object sender, EventArgs e)
        {

        }
    }
}
