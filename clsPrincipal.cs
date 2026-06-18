using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace prySistemaEscolar
{
    internal class clsPrincipal
    {
        private Form misformsabiertos;

        public void agregarAlContenedor(Form formulario, Panel panel)
        {
            //Verifica si esta abierto
            if (misformsabiertos != null)
            {
                misformsabiertos.Close();
                misformsabiertos.Dispose();
            }

            //Abrir el formulario en caso de que no este abierto
            misformsabiertos = formulario;
            panel.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.Sizable;
            formulario.Dock = DockStyle.Fill;

            panel.Controls.Add(formulario);
            panel.Tag = formulario;
            formulario.Show();
        }
    }
}
