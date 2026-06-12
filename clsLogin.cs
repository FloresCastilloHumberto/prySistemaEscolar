using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsLogin
    {

        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        public static string perfil;

        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {

                    string sql = "SELECT perfil FROM tblUsuarios " +
                                 "WHERE nombreUsuario = @usuario AND password =  @password;";

                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("Perfil");
                                MessageBox.Show("Tu perfil es: " + perfil, " sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos.m");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
