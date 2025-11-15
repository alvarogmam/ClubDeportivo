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
    public partial class FrmMenuPrincipal : Form
    {
        private string nombreUsuario;
        private string rolUsuario;

        //Constructor que recibe nombre y rol
        public FrmMenuPrincipal(string nombreUsuario, string rolUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.rolUsuario = rolUsuario;
        }
        //Evento del boton registrar socio, abre la ventana de registro
        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            FrmRegistrarSocio frm = new FrmRegistrarSocio();
            frm.ShowDialog();
        }

        private void lblMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + nombreUsuario;
            lblRol.Text = "Rol: " + rolUsuario;

            // Mostrar un mensaje de bienvenida
            MessageBox.Show($"¡Bienvenido, {nombreUsuario}!",
                            "Ingreso exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //evento para salir al login
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }

        // Evento que lista los socios en una tabla

        private void btnListarSocios_Click(object sender, EventArgs e)
        {
            FrmListadoSocios frm = new FrmListadoSocios();
            frm.ShowDialog();
        }

        //Abre menu registrar un no socio
        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            FrmRegistrarNoSocio frm = new FrmRegistrarNoSocio();
            frm.ShowDialog();
        }

        //Abre munu de cobro de cuota
        private void btnCobrarCuota_Click(object sender, EventArgs e)
        {
            FrmCobrarCuota frm = new FrmCobrarCuota();
            frm.ShowDialog();   // Se abre el formulario como ventana modal
        }

    }
}
