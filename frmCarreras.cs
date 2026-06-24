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
    public partial class frmCarreras : Form
    {
        public int idCarrera;
        clsCarreras carreras = new clsCarreras();

        public frmCarreras()
        {
            InitializeComponent();
            CargarTablaConLosDatos();
        }
        //Funcion para actualizar los datos de DGV segun la BD.
        public void CargarTablaConLosDatos()
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Carga inicial de todos los datos en el DataGridView
                dgvCarreras.DataSource = carreras.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            carreras = new clsCarreras();
            dgvCarreras.DataSource = null;
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Asigna el texto del filtro a la propiedad de la clase
                carreras.NombreCarrera = txtNombreCarrera.Text;

                // Actualiza el DataGridView con los resultados filtrados
                dgvCarreras.DataSource = carreras.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Ancho: {this.Width.ToString()}. Alto: {this.Height.ToString()}");
            int anchoMaximo = this.Width;
            int altoMaximo = this.Height;

            this.Size = new Size(anchoMaximo, altoMaximo);
            carreras.CargarDataGrid();
        }

        //Evento que ocurre al momento de cambiar la celda seleccionada en el dgv
        //su funcion es mostrar el nombre de la carrera y la descripcion en los txtboxs correspondientes
        private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
        {
            //Campo oculto que me servira de referencia para actualizar y eliminar (el id en la celda 0)
            idCarrera = int.Parse(dgvCarreras.CurrentRow.Cells[0].Value.ToString());
            //Visuales, al momento de seleccionar una celda los datos de X celda de la fila seran llevados a los textBoxs
            txtNombre.Text = dgvCarreras.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgvCarreras.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Operacion de tipo ternario: condición ? valorSiVerdadero : valorSiFalso;
                int tipoDeOperacion = idCarrera == 0 ? 0 : 1;
                carreras.IdCarrera = idCarrera;
                carreras.NombreCarrera = txtNombre.Text;
                carreras.Descripcion = txtDescripcion.Text;

                string msg = "";

                if (tipoDeOperacion != 0)
                {
                    //Se le pregunta al usuario si desea actualizar el registro antes de continuar
                    var resp = MessageBox.Show("Confirma si se desea actualizar el registro seleccionado: ", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = carreras.GuardarActualizar(tipoDeOperacion);
                        MessageBox.Show(msg);
                    }
                }
                //En cualquier otro caso que el tipo de operacion no sea actualizar no hara falta preguntar por confirmacion.
                //Y se ejecuta el metodo GuardarActualizar directamente.
                else
                {
                    msg = carreras.GuardarActualizar(tipoDeOperacion);
                    MessageBox.Show(msg);
                }
                CargarTablaConLosDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idCarrera = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtNombre.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = MessageBox.Show("Confirma si se desea eliminar el dato seleccionado: ", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    carreras.IdCarrera = idCarrera;
                    string msg = carreras.Eliminar();
                    MessageBox.Show(msg);
                    CargarTablaConLosDatos();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
