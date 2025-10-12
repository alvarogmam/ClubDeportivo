using ClubDeportivo.Datos; //Permite acceder a las clases del espacio de nombres "Datos" dentro del proyecto "ClubDeportivo"
using MySql.Data.MySqlClient;//Importa las clases necesarias para conectarse a una base de datos MySQL
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void lblUsuario_Click(object sender, EventArgs e) { }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Conectamos el formulario a la base de datos
            try
            {
                MySqlConnection cn = Conexion.getInstancia().CrearConexion();
                MessageBox.Show("Conexión exitosa a la base de datos");
                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar: " + ex.Message);
            }

            // Quita el foco del textbox al iniciar
            this.ActiveControl = null;
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando llega el foco 
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            //este evento se ejecuta cuando se va el foco 
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }


        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
                txtPass.ForeColor = Color.Black;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.Gray;
            }
        }



        //Este evento se ejecuta al hacer click en el boton ingresar, se valida el usuario en la base de datos.

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtPass.Text.Trim();
            string nombre, rol;

            UsuarioDatos ud = new UsuarioDatos();

            if (ud.ValidarUsuario(usuario, clave, out nombre, out rol))
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal(nombre, rol);
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el menú principal y vuelve al login
            DialogResult result = MessageBox.Show("¿Desea salir del sistema?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }

}

