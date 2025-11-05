using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using ClubDeportivo.Datos;

namespace ClubDeportivo.Datos
{
    internal class UsuarioDatos
    {
        //Metodo que valida si el usuario y contraseña existen en la base de datos. true si las credenciales son correctas, false si no.
        public bool ValidarUsuario(string usuario, string clave, out string nombreCompleto, out string rol)
        {
            nombreCompleto = usuario; //Muestra el nombre de usuario
            rol = string.Empty;

            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();

                    //Llamamnos al procedimiento almacenado en la base de datos
                 

                    using (MySqlCommand cmd = new MySqlCommand("sp_validar_login", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_user", usuario);
                        cmd.Parameters.AddWithValue("@p_pass", clave);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                               
                                rol = dr["rol"].ToString();
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
        }
    }
}
