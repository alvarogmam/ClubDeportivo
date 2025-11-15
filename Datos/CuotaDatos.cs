using ClubDeportivo.Modelos;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Datos
{
    public class CuotaDatos
    {
        // Listar cuota pendiente según DNI
        public DataTable ListarCuotaPendiente(int dni)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection con = new MySqlConnection();

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                MySqlCommand cmd = new MySqlCommand("sp_listar_cuota_pendiente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_dni", dni);

                con.Open();
                resultado = cmd.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar cuota: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        // Cobrar la cuota
        public static bool CobrarCuota(int idSocio, int idCuota, decimal total, string medioPago, int cuotas)
        {
            MySqlConnection cn = null;
            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                cn.Open();

                MySqlCommand cmd = new MySqlCommand("sp_cobrar_cuota", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_idSocio", idSocio);
                cmd.Parameters.AddWithValue("@p_idCuota", idCuota);
                cmd.Parameters.AddWithValue("@p_medioPago", medioPago);
                cmd.Parameters.AddWithValue("@p_cuotasTarjeta", cuotas);
                cmd.Parameters.AddWithValue("@p_montoPagado", total);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open) cn.Close();
            }
        }



        // Obtener cuota actual, registra pago(Cobrar)
        public static Cuota ObtenerCuotaActual(int idSocio)
        {
            MySqlConnection cn = null;
            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                cn.Open();

                string sql = @"SELECT idCuota, idSocio, monto, fechaVencimiento, estado
                       FROM Cuota
                       WHERE idSocio = @id
                         AND estado = 'PENDIENTE'
                       ORDER BY fechaVencimiento DESC
                       LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", idSocio);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    return new Cuota()
                    {
                        IdCuota = Convert.ToInt32(dr["idCuota"]),
                        IdSocio = Convert.ToInt32(dr["idSocio"]),
                        Monto = Convert.ToDecimal(dr["monto"]),
                        FechaVencimiento = Convert.ToDateTime(dr["fechaVencimiento"]),
                        Estado = dr["estado"].ToString()
                    };
                }

                return null;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open) cn.Close();
            }
        }


        // Cobra la cuota y queda marcada como pagada
        public static bool CobrarCuota(int idSocio, decimal total, string medioPago, int cuotas)
        {
            MySqlConnection cn = null;
            try
            {
                cn = Conexion.getInstancia().CrearConexion();
                cn.Open();

                string sql = @"UPDATE Cuota 
                           SET estado = 'PAGADA'
                           WHERE idSocio = @id 
                           ORDER BY fechaVencimiento DESC 
                           LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@id", idSocio);

                int filas = cmd.ExecuteNonQuery();
                return filas == 1;
            }
            finally
            {
                if (cn != null && cn.State == ConnectionState.Open) cn.Close();
            }
        }

        // Genera una cuota si el socio no tiene cuotas
        public static bool GenerarCuota(int idSocio, decimal monto)
        {
            MySqlConnection con = Conexion.getInstancia().CrearConexion();

            try
            {
                string query = @"INSERT INTO Cuota (idSocio, monto, fechaVencimiento, estado)
                         VALUES (@idSocio, @monto, DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'PENDIENTE')";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@idSocio", idSocio);
                cmd.Parameters.AddWithValue("@monto", monto);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar cuota: " + ex.Message);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public static bool ActualizarMonto(int idCuota, decimal nuevoMonto)
        {
            try
            {
                using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
                {
                    con.Open();

                    string query = "UPDATE Cuota SET monto = @monto WHERE idCuota = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@monto", nuevoMonto);
                        cmd.Parameters.AddWithValue("@id", idCuota);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el monto: " + ex.Message);
                return false;
            }
        }

    }
}

