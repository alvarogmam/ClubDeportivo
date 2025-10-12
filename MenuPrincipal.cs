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

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {

        }

        private void lblMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario: " + nombreUsuario;
            lblRol.Text = "Rol: " + rolUsuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                Application.Exit();
        }
    }
}
