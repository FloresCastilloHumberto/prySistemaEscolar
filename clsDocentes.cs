using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsDocentes
    {
        private int clave;
        private string nombreDocente;
        private string puesto;
        private string telefono;
        private string correo;
        private int idUsuario;

        //Estos atributos agregamos para registrar el usuario
        private string nombreUsuario;
        private string password;
        private string perfil;

        // Adaptador y tabla virtuales de la clase
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        private MySqlCommand comando;


        public int Clave { get => clave; set => clave = value; }
        public string NombreDocente { get => nombreDocente; set => nombreDocente = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Unimos las 4 tablas mediante INNER JOIN para mostrar descripciones claras en el Grid
                    string sql = "SELECT A.claveDocente AS Clave, " +
                                 "A.nombreDocente AS Nombre, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchPASSWORD, " +
                                 "U.vchperfil, " +
                                 "A.puesto, A.telefono, A.correo, A.idUsuario " +
                                 "FROM tbldocentes A " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }//liberar la consulta
                }//liberar la conexion
            }
            catch (Exception ex)
            {
                throw new Exception("error en la conexión al cargar catalogo de alumnos " + ex.Message);
            }
            return tabla;
        }

        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Consulta SQL usando el operador LIKE para coincidencias parciales
                    string sql = "SELECT A.claveDocente AS clave, " +
                                 "A.nombreDocente AS Nombre, " +
                                 "U.vchnombreUsuario AS Usuario, " +
                                 "U.vchPASSWORD, " + //Se agrega password
                                 "U.vchperfil, " +   // se  agrega perfil
                                 "A.puesto, A.telefono, A.correo, A.idUsuario " +
                                 "FROM tbldocentes A " +
                                 "INNER JOIN tblusuarios U ON A.idUsuario = U.intidUsuario WHERE A.claveDocente LIKE @clave;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        // Se agregan los comodines '%' para buscar cualquier coincidencia que contenga el texto
                        comando.Parameters.AddWithValue("@clave", "%" + Clave + "%");

                        using (consulta = new MySqlDataAdapter(comando))
                        {
                            consulta.Fill(tabla);
                        }
                    } // Libera el comando automáticamente
                } // Libera la conexión automáticamente
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        
    }
}
