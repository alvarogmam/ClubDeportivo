using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion con = null;

        // Constructor privado: evita que se creen múltiples instancias
        private Conexion()
        {
            this.baseDatos = "club_deportivo"; //Nombre de la base de datos
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root"; // En caso de que tu base de datos tenga un 
            this.clave = "root"; // nombre y contraseña distintos, aqui deberias reemplazarlos
        }

        // Crea y devuelve una conexión MySQL abierta
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "server=" + this.servidor +
                ";port=" + this.puerto +
                ";user id=" + this.usuario +
                ";password=" + this.clave +
                ";database=" + this.baseDatos;

           
            }
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception("Error al crear la conexion" + ex.Message);
            }
            return cadena;
        }

        // Para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // Quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); //Se crea una nueva
            }
            return con;
        }
    }
}
