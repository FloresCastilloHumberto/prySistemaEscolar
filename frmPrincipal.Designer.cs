namespace prySistemaEscolar
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pcbMenu = new PictureBox();
            pcbTitulo = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbDocentes = new PictureBox();
            pcbUsuarios = new PictureBox();
            pnlContenedor = new Panel();
            pcbSalir = new PictureBox();
            pcbTutores = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.Image = (Image)resources.GetObject("pcbMenu.Image");
            pcbMenu.Location = new Point(12, 27);
            pcbMenu.Margin = new Padding(3, 2, 3, 2);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(379, 700);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbTitulo
            // 
            pcbTitulo.Image = (Image)resources.GetObject("pcbTitulo.Image");
            pcbTitulo.Location = new Point(449, 27);
            pcbTitulo.Margin = new Padding(3, 2, 3, 2);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(897, 72);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 1;
            pcbTitulo.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.Image = (Image)resources.GetObject("pcbAlumnos.Image");
            pcbAlumnos.Location = new Point(92, 127);
            pcbAlumnos.Margin = new Padding(3, 2, 3, 2);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(222, 78);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 2;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.Click += pcbAlumnos_Click;
            pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
            pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
            pcbCarreras.Location = new Point(92, 224);
            pcbCarreras.Margin = new Padding(3, 2, 3, 2);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(222, 78);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.Click += pcbCarreras_Click;
            pcbCarreras.MouseDown += pcbGeneral_MouseDown;
            pcbCarreras.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbDocentes
            // 
            pcbDocentes.Image = (Image)resources.GetObject("pcbDocentes.Image");
            pcbDocentes.Location = new Point(92, 325);
            pcbDocentes.Margin = new Padding(3, 2, 3, 2);
            pcbDocentes.Name = "pcbDocentes";
            pcbDocentes.Size = new Size(222, 69);
            pcbDocentes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocentes.TabIndex = 4;
            pcbDocentes.TabStop = false;
            pcbDocentes.Click += pcbDocentes_Click;
            pcbDocentes.MouseDown += pcbGeneral_MouseDown;
            pcbDocentes.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = (Image)resources.GetObject("pcbUsuarios.Image");
            pcbUsuarios.Location = new Point(92, 421);
            pcbUsuarios.Margin = new Padding(3, 2, 3, 2);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(222, 69);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 5;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.MouseDown += pcbGeneral_MouseDown;
            pcbUsuarios.MouseUp += pcbGeneral_MouseUp;
            // 
            // pnlContenedor
            // 
            pnlContenedor.AutoSize = true;
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.Location = new Point(437, 118);
            pnlContenedor.Margin = new Padding(3, 2, 3, 2);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(921, 609);
            pnlContenedor.TabIndex = 0;
            // 
            // pcbSalir
            // 
            pcbSalir.BackgroundImage = Properties.Resources.salir;
            pcbSalir.BackgroundImageLayout = ImageLayout.Stretch;
            pcbSalir.Location = new Point(92, 612);
            pcbSalir.Margin = new Padding(3, 2, 3, 2);
            pcbSalir.Name = "pcbSalir";
            pcbSalir.Size = new Size(222, 69);
            pcbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSalir.TabIndex = 6;
            pcbSalir.TabStop = false;
            pcbSalir.Click += pcbSalir_Click;
            pcbSalir.MouseDown += pcbGeneral_MouseDown;
            pcbSalir.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbTutores
            // 
            pcbTutores.Image = Properties.Resources.Tutores;
            pcbTutores.Location = new Point(92, 516);
            pcbTutores.Margin = new Padding(3, 2, 3, 2);
            pcbTutores.Name = "pcbTutores";
            pcbTutores.Size = new Size(222, 69);
            pcbTutores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTutores.TabIndex = 7;
            pcbTutores.TabStop = false;
            pcbTutores.Click += pcbTutores_Click;
            pcbTutores.MouseDown += pcbGeneral_MouseDown;
            pcbTutores.MouseUp += pcbGeneral_MouseUp;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 204, 255);
            ClientSize = new Size(1370, 749);
            Controls.Add(pcbSalir);
            Controls.Add(pcbTutores);
            Controls.Add(pcbUsuarios);
            Controls.Add(pcbDocentes);
            Controls.Add(pcbCarreras);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Escolar";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbTitulo;
        private PictureBox pcbAlumnos;
        private PictureBox pcbCarreras;
        private PictureBox pcbDocentes;
        private PictureBox pcbUsuarios;
        private Panel pnlContenedor;
        private PictureBox pcbSalir;
        private PictureBox pcbTutores;
    }
}