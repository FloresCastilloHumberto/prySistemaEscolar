namespace prySistemaEscolar
{
    partial class frmCarreras
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
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            txtNombreCarrera = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.iconCarrera;
            pcbLogo.Location = new Point(277, 30);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(121, 80);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(493, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(144, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(button2);
            pnlContenedor.Controls.Add(button1);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(txtDescripcion);
            pnlContenedor.Controls.Add(txtNombre);
            pnlContenedor.Location = new Point(266, 116);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(584, 151);
            pnlContenedor.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.BtnBorrarCarrera1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(389, 76);
            button2.Name = "button2";
            button2.Size = new Size(99, 61);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.BtnNuevaCarrera1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(74, 76);
            button1.Name = "button1";
            button1.Size = new Size(107, 61);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.ImagenGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(242, 76);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 61);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(74, 47);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion de la Carrera";
            txtDescripcion.Size = new Size(435, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de la Carrera";
            txtNombre.Size = new Size(434, 23);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Location = new Point(266, 317);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(584, 190);
            dgvCarreras.TabIndex = 3;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Location = new Point(670, 288);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Busacar Carrera";
            txtNombreCarrera.Size = new Size(180, 23);
            txtNombreCarrera.TabIndex = 4;
            txtNombreCarrera.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1226, 547);
            Controls.Add(txtNombreCarrera);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlContenedor);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmCarreras";
            Text = "frmCarreras";
            Load += frmCarreras_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Button btnGuardar;
        private DataGridView dgvCarreras;
        private Button button1;
        private Button button2;
        private TextBox txtNombreCarrera;
    }
}