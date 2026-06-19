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
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.iconCarrera;
            pcbLogo.Location = new Point(709, 30);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(116, 105);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            pcbLogo.Click += pictureBox1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(442, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(214, 65);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(btnEliminar);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(btnNuevo);
            pnlContenedor.Controls.Add(txtDescripcion);
            pnlContenedor.Controls.Add(txtNombre);
            pnlContenedor.Location = new Point(266, 153);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(584, 215);
            pnlContenedor.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackgroundImage = Properties.Resources.BtnBorrar;
            btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminar.Location = new Point(416, 133);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 71);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.ImagenGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(255, 133);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 71);
            btnGuardar.TabIndex = 3;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.Imagen2Nuevo;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(82, 133);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(92, 71);
            btnNuevo.TabIndex = 2;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(73, 73);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion de la Carrera";
            txtDescripcion.Size = new Size(435, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de la Carrera";
            txtNombre.Size = new Size(434, 23);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarreras.Location = new Point(266, 384);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(584, 151);
            dgvCarreras.TabIndex = 3;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1226, 547);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlContenedor);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmCarreras";
            Text = "frmCarreras";
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
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridView dgvCarreras;
    }
}