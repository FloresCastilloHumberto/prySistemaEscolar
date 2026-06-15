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

        //atributo estatico.
        private static string perfil;
        private static bool esAdministrador;
        private static bool esDocente;

        //Propiedad estatica
        public static bool EsAdministrador { get => esAdministrador; private set => esAdministrador = value; }
        public static bool EsDocente { get => esDocente; private set => esDocente = value; }
        public void asignarPermisos()
        {
            switch (perfil)
            {
                case "Administrador":
                    esAdministrador= true;
                    esDocente = false;
                    break;
                case "Docente":
                    esAdministrador = false;
                    esDocente = true;                        
                    break;
                default:
                    esAdministrador = false;
                    esDocente = false;                    
                    break;
            }
        }

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
                                asignarPermisos();

                                if (!esAdministrador && !esDocente)
                                {
                                    throw new Exception($"El perfil {perfil} no tiene permiso para acceder");
                                }

                                MessageBox.Show("Tu perfil es: " + perfil, "Sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos.");
                            }                           
                        }
                    }
                }
            }  //Cerrar el Try Catch

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
