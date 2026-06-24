
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
        private string descripcion;

        private int idCarrera; //atributo para referenciar en update y delete

        // Usamos una tabla temporal y un adaptador
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        //Usamos command para insertar o actualizar
        private MySqlCommand comando;

        // Propiedad pública para el atributo nombreCarrera
        public string NombreCarrera
        {
            get => nombreCarrera;
            set => nombreCarrera = value;
        }
        public int IdCarrera { get => idCarrera; set => idCarrera = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }


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

        // Método para consultar por coincidencias (Búsqueda en tiempo real, Busqueda tipo Like)
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

        //METODO PARA AGREGAR O ACTUALIZAR CARRERAS.
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    switch (tipoOperacion)
                    {
                        case 0: //Insertar nuevo registro
                            string sqlN = "INSERT INTO tblcarreras (nombreCarrera,descripcion) VALUES (@nombreCarrera, @descripcion)";
                            using (comando = new MySqlCommand(sqlN, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se guardo correctamente";
                                }
                                else
                                {
                                    msg = "Error, no se guardaron los datos";
                                }
                            } //Termina el using, libera la operacion de insercion
                            break;
                        case 1: // actualizar old registro
                            string sqlA = "UPDATE tblcarreras C SET C.nombreCarreras = @nombreCarrera, C.descripcion = @descripcion WHERE C.idCarrera = @idCarrera";
                            using (comando = new MySqlCommand(sqlA, conexion))
                            {
                                comando.Parameters.AddWithValue("nombreCarrera", nombreCarrera);
                                comando.Parameters.AddWithValue("descripcion", descripcion);
                                comando.Parameters.AddWithValue("idCarrera", idCarrera);

                                int filasAfectadas = comando.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    msg = "El registro se actualizo correctamente";                            
                                }
                                else
                                {
                                    msg = "Error, no se pudieron actualizar los datos";
                                }
                            } //Libera la operacion de insercion
                            break;
                    }
                }//Libera la conexion             
            }
            catch(Exception ex)
            {
                throw new Exception("Error" + ex.Message);                
            }
            return msg;
        }

        //METODO PARA ELIMINAR ALGUN REGISTRO
        public string Eliminar()
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sqlE = "DELETE FROM tblcarreras C WHERE C.idCarrera = @idCarrera;";
                    using (comando = new MySqlCommand(sqlE, conexion))
                    {
                        comando.Parameters.AddWithValue("@idCarrera", idCarrera);
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            msg = "Datos eliminados correctamente";
                        }
                        else
                        {
                            msg = "Los datos no se pudieron eliminar correctamente";
                        }
                    } //Libera la eliminacion
                }
            } catch(Exception ex)
            {
                throw new Exception ("Error " + ex.Message);                
            }
            return msg;
        }
    }
}
