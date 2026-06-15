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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pcbGeneral_MouseDown(object miPicture, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)miPicture;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }

        private void pcbGeneral_MouseUp(object miPicture, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)miPicture;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Ancho:" + this.Width.ToString() + "Alto:" + this.Height.ToString());

            //Indica que pcbMenu es el padre de los botones
            pcbAlumnos.Parent = pcbMenu;
            pcbCarreras.Parent = pcbMenu;
            pcbDocentes.Parent = pcbMenu;
            pcbUsuarios.Parent = pcbMenu;
            pcbSalir.Parent = pcbMenu;

            //El color del fondo es transparente
            pcbAlumnos.BackColor = Color.Transparent;
            pcbCarreras.BackColor = Color.Transparent;
            pcbDocentes.BackColor = Color.Transparent;
            pcbUsuarios.BackColor = Color.Transparent;
            pcbSalir.BackColor = Color.Transparent;
        }

        private void pcbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbAlumnos_Click(object sender, EventArgs e)
        {

        }

       
    }
}
