
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsCarreras
    {
        // Atributos privados
        private string nombreCarrera;
        // Usamos una tabla temporal y un adaptador
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        // Propiedad pública para el atributo nombreCarrera
        public string NombreCarrera
        {
            get => nombreCarrera;
            set => nombreCarrera = value;
        }

        // Método para cargar todos los datos en el DataGrid
        public DataTable CargarDataGrid()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblcarreras;";
                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion de la base de datos: " + ex.Message);
            }
            return tabla;
        }

        // Método para consultar por coincidencias (Búsqueda en tiempo real)
        public DataTable Consultar()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Consulta SQL usando el operador LIKE para coincidencias parciales
                    string sql = "SELECT idCarrera AS Clave, nombreCarrera AS Carrera, descripcion AS Descripcion FROM tblcarreras WHERE nombreCarrera LIKE @carrera;";

                    using (var comando = new MySqlCommand(sql, conexion))
                    {
                        // Se agregan los comodines '%' para buscar cualquier coincidencia que contenga el texto
                        comando.Parameters.AddWithValue("@carrera", "%" + nombreCarrera + "%");

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
