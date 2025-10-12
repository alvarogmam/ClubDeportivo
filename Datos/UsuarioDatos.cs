using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ClubDeportivo.Datos;

namespace ClubDeportivo.Datos
{
    internal class UsuarioDatos
    {
        //Metodo que valida si el usuario y contraseña existen en la base de datos. true si las credenciales son correctas, false si no.
        public bool ValidarUsuario(string usuario, string clave, out string nombreCompleto, out string rol)
        {
            nombreCompleto = string.Empty;
            rol = string.Empty;

            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();

                    string sql = @"SELECT p.nombre, p.apellido, u.rol
                                   FROM usuario u
                                   INNER JOIN persona p ON u.idPersona = p.idPersona
                                   WHERE u.username = @usuario
                                   AND u.password_hash = SHA2(@clave,256)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                nombreCompleto = dr["nombre"].ToString() + " " + dr["apellido"].ToString();
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
