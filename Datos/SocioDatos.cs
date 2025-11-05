using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    public class SocioDatos
    {
        //Inserta un nuevo socio en la tabla Persona.
        public bool RegistrarSocio(string nombre, string apellido, string dni, string mail, bool aptoFisico)
        {
            //  bool resultado = false;


            {
                try
                {
                    // Crear conexión a la base de datos
                    using (MySqlConnection conexion = Conexion.getInstancia().CrearConexion())
                    {
                        conexion.Open();

                        //  Preparar el comando
                        using (MySqlCommand cmd = new MySqlCommand("sp_registrar_socio", conexion))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("p_nombre", nombre);
                            cmd.Parameters.AddWithValue("p_apellido", apellido);
                            cmd.Parameters.AddWithValue("p_dni", dni);
                            cmd.Parameters.AddWithValue("p_mail", mail);
                            cmd.Parameters.AddWithValue("p_aptoFisico", aptoFisico);


                            cmd.ExecuteNonQuery();
                            return true;
                        }

                    }
                }
                catch (MySqlException ex)
                {

                    if (ex.Number == 1644) //Signal sqlstate '45000'
                        throw new Exception(ex.Message);
                    else
                        throw new Exception("Error al registrar socio: " + ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error general al registrar socio: " + ex.Message);
                }
            }

        }
    }
}
