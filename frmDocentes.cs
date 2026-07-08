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
    public partial class frmDocentes : Form
    {
        clsDocentes docentes;
        int idClave;
        int idUsuario;

        public frmDocentes()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                dgvDocentes.DataSource = docentes.CargarDataGrid();
                dgvDocentes.Columns["Usuario"].Visible = false;
                dgvDocentes.Columns["vchPASSWORD"].Visible = false;
                dgvDocentes.Columns["vchperfil"].Visible = false;
                dgvDocentes.Columns["idUsuario"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDocentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //Esto es para poder saber si es nuevo o vamos a actualizar
                idClave = int.Parse(dgvDocentes.CurrentRow.Cells["Clave"].Value.ToString());
                idUsuario = int.Parse(dgvDocentes.CurrentRow.Cells["idUsuario"].Value.ToString());

                //Esto es para la tabla alumnos
                txtClave.Text = idClave.ToString();
                txtNombre.Text = dgvDocentes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPuesto.Text = dgvDocentes.CurrentRow.Cells["Puesto"].Value.ToString();
                txtTelefono.Text = dgvDocentes.CurrentRow.Cells["telefono"].Value.ToString();
                txtCorreo.Text = dgvDocentes.CurrentRow.Cells["correo"].Value.ToString();

                //Esto es para la tala usuarios
                txtUsuario.Text = dgvDocentes.CurrentRow.Cells["Usuario"].Value.ToString();
                txtPassword.Text = dgvDocentes.CurrentRow.Cells["vchpassword"].Value.ToString();
                cmbPerfil.Text = dgvDocentes.CurrentRow.Cells["vchperfil"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mapear los datos seleccionados: " + ex.Message);
            }
        }

        private void txtClaveDocente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClaveDocente.Text))
            {
                CargarGrid();
                return;
            }

            docentes = new clsDocentes();
            dgvDocentes.DataSource = null;
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            try
            {
                // Asigna el texto del filtro a la propiedad de la clase
                docentes.Clave = int.Parse(txtClaveDocente.Text);

                // Actualiza el DataGridView con los resultados filtrados
                dgvDocentes.DataSource = docentes.Consultar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requiere asignar datos de entrada" + ex.Message);
            }
        }

    }
}
