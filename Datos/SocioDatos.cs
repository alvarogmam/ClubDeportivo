using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using ClubDeportivo.Modelos;

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

        public DataTable ListarSocios()
        {
            DataTable tabla = new DataTable();

            try
            {
                using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_listar_socios", cn))
                    {
                        //Indica que se trata de un procedimiento almacenado
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                throw new Exception ("Error al obtener la lista de socios: " + ex.Message);
            }
            return tabla;
        }

        // Busca socios en la base de datos
        public DataTable BuscarSocios(string filtro)
        {
            using (MySqlConnection cn = Conexion.getInstancia().CrearConexion())
            {
                MySqlCommand cmd = new MySqlCommand("sp_buscar_socios", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_filtro", filtro);
                cn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Busca socios por DNI
        public static Socio BuscarPorDni(string dni)
        {
            MySqlConnection cn = null;
            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                cn.Open();

                string sql = @"SELECT s.idSocio, p.idPersona, p.nombre, p.apellido, p.dni
                           FROM Persona p
                           INNER JOIN Socio s ON s.idSocio = p.idPersona
                           WHERE p.dni = @dni";

                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@dni", dni);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Socio()
                    {
                        IdSocio = Convert.ToInt32(dr["idSocio"]),
                        IdPersona = Convert.ToInt32(dr["idPersona"]),
                        Nombre = dr["nombre"].ToString(),
                        Apellido = dr["apellido"].ToString(),
                        Dni = dr["dni"].ToString()
                    };
                }

                return null;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open) cn.Close();
            }
        }

    }
}
