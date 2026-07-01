using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaEscolar
{
    public partial class frmAlumnos : Form
    {
        clsAlumnos alumnos;

        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
        }

        //meotodo para cargar el fatagriview
        public void CargarGrid()
        {
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Asignamos la tabla virtual de la clase directamente al control visual
                dgvAlumnos.DataSource = alumnos.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void CargarCombos()
        {
            alumnos = new clsAlumnos();


            try
            {
                DataTable dtCarreras = alumnos.ObtenerCarreras();
                // Creamos la fila del placeholder para la Carrera
                DataRow filaPCarrera = dtCarreras.NewRow();
                filaPCarrera["idCarrera"] = 0;
                filaPCarrera["nombreCarrera"] = "-- Selecciona una Carrera --";
                dtCarreras.Rows.InsertAt(filaPCarrera, 0); // Insertar al inicio de la lista

                // Enlazamos los datos al ComboBox visual
                cmbCarrera.DataSource = dtCarreras;
                cmbCarrera.DisplayMember = "nombreCarrera"; // El texto visible
                cmbCarrera.ValueMember = "idCarrera";       // La llave primaria real
                cmbCarrera.SelectedIndex = 0;              // Forzar a que muestre el placeholder


                DataTable dtTutores = alumnos.ObtenerTutores();
                // Creamos la fila del placeholder para la Carrera
                DataRow filaPTutores = dtTutores.NewRow();
                filaPTutores["idTutor"] = 0;
                filaPTutores["nombreTutor"] = "-- Selecciona un tutor --";
                dtTutores.Rows.InsertAt(filaPTutores, 0); // Insertar al inicio de la lista
                                                          // Enlazamos los datos al ComboBox visual
                cmbTutor.DataSource = dtTutores;
                cmbTutor.DisplayMember = "nombreTutor";    // El texto visible
                cmbTutor.ValueMember = "idTutor";          // La llave primaria real
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rellenar los catálogos en los menús desplegables: " + ex.Message);
            }
        }


        
        public frmAlumnos()
        {
            InitializeComponent();
            CargarGrid();
            CargarCombos();
        }

        private void txtMatriculaAlumno_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtMatriculaAlumno.Text))
            {
                CargarGrid();
                return;
            }
            alumnos = new clsAlumnos();
            dgvAlumnos.DataSource = null;
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Asigna el texto del filtro a la propiedad de la clase
                alumnos.Matricula = int.Parse(txtMatriculaAlumno.Text);

                // Actualiza el DataGridView con los resultados filtrados
                dgvAlumnos.DataSource = alumnos.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos de entrada" + ex.Message);
            }
        }

    }
}

