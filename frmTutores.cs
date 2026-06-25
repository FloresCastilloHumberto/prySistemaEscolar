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
    public partial class frmTutores : Form
    {
        clsTutores tutores;
        int idTutor;

        public frmTutores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                dgvTutores.DataSource = tutores.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNombreTutor_TextChanged(object sender, EventArgs e)
        {
            tutores = new clsTutores();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreTutor = txtNombreTutor.Text;
                dgvTutores.DataSource = tutores.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            //campo oculto que me servira de referencia y actualizar 
            idTutor = int.Parse(dgvTutores.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvTutores.CurrentRow.Cells[1].Value.ToString();
            txtParentesco.Text = dgvTutores.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvTutores.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvTutores.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvTutores.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoOperacion = idTutor == 0 ? 0 : 1;

                tutores.IdTutor = idTutor;
                tutores.NombreTutor = txtNombre.Text;
                tutores.Parentesco = txtParentesco.Text;
                tutores.Direccion = txtDireccion.Text;
                tutores.Telefono = txtTelefono.Text;
                tutores.Correo = txtCorreo.Text;

                string msg = "";
                if (tipoOperacion != 0)
                {
                    var resp = MessageBox.Show("Confirma si se desea actualizar el registro seleccionado:", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resp == DialogResult.Yes)
                    {
                        msg = tutores.GuardarActualizar(tipoOperacion);
                        MessageBox.Show(msg);
                    }
                }
                else
                {
                    msg = tutores.GuardarActualizar(tipoOperacion);
                    MessageBox.Show(msg);
                }
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            idTutor = 0;
            txtNombre.Clear();
            txtParentesco.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tutores.IdTutor = idTutor;
                var resp = MessageBox.Show("Confirmar que desea eliminar el dato seleccionado", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    string msg = tutores.Eliminar();
                    MessageBox.Show(msg);
                    CargarGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmTutores_Load(object sender, EventArgs e)
        {

        }
    }

}
