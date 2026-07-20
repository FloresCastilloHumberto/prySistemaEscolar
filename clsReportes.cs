using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySistemaEscolar
{
    internal class clsReportes
    {
        DataTable tabla;
        MySqlDataAdapter consulta;

        public DataTable ConsultarAlumnoRiesgo()
        {
            tabla = new DataTable();

            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT A.matricula AS Matricula, " +
                                 "A.nombreAlumno AS Nombre, " +
                                 "A.apellidoP AS 'A. Paterno', " +
                                 "A.apellidoM AS 'A. Materno' " +
                                 "C.nombreCarrera AS Carrera, " +
                                 "A.promedioBachillerato AS Promedio " +
                                 "FROM tblalumnos A " +
                                 "INNER JOIN tblcarreras C ON A.idCarrera = C.idCarrera " +
                                 "WHERE A.promedioBachillerato <= 8.0;";
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Error al consultar alumnos en riesgo: " + ex.Message);
            }
            return tabla;            
        }
    }
}
