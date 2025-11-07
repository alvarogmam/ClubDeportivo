using MySql.Data.MySqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo.Datos
{
    public class NoSocioDatos
    {
        public bool RegistrarNoSocio(string nombre, string apellido, string dni, string mail, decimal pagoDiario)
        {
            bool exito = false;

            try
            {
                using (MySqlConnection con = Conexion.getInstancia().CrearConexion())
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand("sp_registrar_no_socio", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("p_nombre", nombre);
                        cmd.Parameters.AddWithValue("p_apellido", apellido);
                        cmd.Parameters.AddWithValue("p_dni", dni);
                        cmd.Parameters.AddWithValue("p_mail", mail);
                        cmd.Parameters.AddWithValue("p_pagoDiario", pagoDiario);

                        cmd.ExecuteNonQuery();
                        exito = true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar No Socio: " + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exito;
        }
    }
}
