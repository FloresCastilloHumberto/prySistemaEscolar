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
        public void LimpiarPanel(Panel panelDestino)
        {
            foreach (Control control in panelDestino.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;

                }
            }
        }
        //METODO CREADO PARA GUARDAR Y ACTUALIZAR CAMBIOS DENTRO DE LA BD.
        public string GuardarActualizar(int tipoOperacion)
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            switch (tipoOperacion)
                            {
                                case 0: //NUEVO E INSERTAR
                                        //insertamos en la tabla tblusuarios
                                    string sqlInsUser = "INSERT INTO tblusuarios(vchnombreUsuario, vchPASSWORD, vchperfil, vchestado)" +
                                                        "VALUES(@nomUser, MD5(@pass), @perfil, 'Activo'); SELECT LAST_INSERT_ID();";

                                    //Se recupera el ultimo ID insertado
                                    int nuevoIdUsuario = 0;
                                    using (comando = new MySqlCommand(sqlInsUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@pass", password);
                                        comando.Parameters.AddWithValue("@perfil", perfil);
                                        nuevoIdUsuario = Convert.ToInt32(comando.ExecuteScalar());
                                    }

                                    // Paso B: Insertar el docente en tbldocentes vinculando el ID de usuario obtenido
                                    string sqlInsDocente = "INSERT INTO tbldocentes(claveDocente, idUsuario, nombreDocente, puesto, telefono, correo)" +
                                                          "VALUES(@clave, @idUsuario, @nombre, @puesto, @tel, @correo);";

                                    using (comando = new MySqlCommand(sqlInsDocente, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@clave", Clave);
                                        comando.Parameters.AddWithValue("@idUsuario", nuevoIdUsuario);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }

                                    msg = "El docente y sus credenciales se guardaron correctamente.";
                                    break;
                                case 1: // ACTUALIZAR
                                        // Paso A: Actualizar la tabla de usuarios utilizando el ID que recuperamos en el clic del Grid
                                    string sqlUpdUser = "UPDATE tblusuarios SET vchnombreUsuario = @nomUser, vchperfil = @perfil " +
                                                        "WHERE intidUsuario = @idUsuario;";

                                    using (comando = new MySqlCommand(sqlUpdUser, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                        comando.Parameters.AddWithValue("@nomUser", nombreUsuario);
                                        comando.Parameters.AddWithValue("@perfil", perfil);

                                        comando.ExecuteNonQuery();
                                    }

                                    // Paso B: Actualizar los datos del expediente en tbldocentes mediante su clave
                                    string sqlUpdAlumno = "UPDATE tbldocentes SET nombreDocente = @nombre, puesto = @puesto," +
                                                          "telefono = @tel, correo = @correo WHERE claveDocente = @clave;";

                                    using (comando = new MySqlCommand(sqlUpdAlumno, conexion, transaccion))
                                    {
                                        comando.Parameters.AddWithValue("@clave", Clave);
                                        comando.Parameters.AddWithValue("@nombre", nombreDocente);
                                        comando.Parameters.AddWithValue("@puesto", puesto);
                                        comando.Parameters.AddWithValue("@tel", telefono);
                                        comando.Parameters.AddWithValue("@correo", correo);

                                        comando.ExecuteNonQuery();
                                    }
                                    msg = "Los datos del docente se actualizaron correctamente.";
                                    break;
                            }
                            //Si todo se ejecuto sin errores en el switch, confirmamos los cambios en la bd
                            transaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            //Si algo fallo en el usuario o en el alumno, deshacemos todo para evitar incosistencias
                            transaccion.Rollback();
                            throw new Exception("Error en la operacion. Se cancelan los cambios: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion: " + ex.Message);
            }

            return msg;
        } //Finaliza el metodo

        public string Eliminar()
        {
            string msg = "";
            clsConexion conexionBD = new clsConexion();

            try
            {
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            //eliminamos alumnos
                            string sqlDelDocente = "DELETE FROM tbldocentes WHERE claveDocente = @clave;";
                            using (comando = new MySqlCommand(sqlDelDocente, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@clave", clave);
                                comando.ExecuteNonQuery();
                            }

                            //eliminamos el usuario
                            string sqlDelUsuario = "DELETE FROM tblusuarios WHERE intidUsuario = @idUsuario;";
                            using (comando = new MySqlCommand(sqlDelUsuario, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                                comando.ExecuteNonQuery();
                            }

                            //si en ambas se elimina correctamente
                            transaccion.Commit();
                            msg = "El alumno y sus credenciales de usuario han sido eliminados del sistema.";
                        }
                        catch (Exception ex)
                        {
                            // Si algo falla, deshacemos la operación para no dejar datos huérfanos
                            transaccion.Rollback();
                            throw new Exception("No se pudo completar la eliminación. Cambios revertidos: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión al eliminar: " + ex.Message);
            }

            return msg;
        }

    }
}
