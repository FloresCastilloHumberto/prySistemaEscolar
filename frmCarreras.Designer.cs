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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            btnBorrar = new Button();
            btnNuevo = new Button();
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
            pcbLogo.Location = new Point(74, 47);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(129, 96);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(341, 47);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(144, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Carreras";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(btnBorrar);
            pnlContenedor.Controls.Add(btnNuevo);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(txtDescripcion);
            pnlContenedor.Controls.Add(txtNombre);
            pnlContenedor.Location = new Point(74, 149);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(670, 236);
            pnlContenedor.TabIndex = 2;
            // 
            // btnBorrar
            // 
            btnBorrar.BackgroundImage = Properties.Resources.BtnBorrarCarrera1;
            btnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorrar.Location = new Point(483, 143);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(117, 77);
            btnBorrar.TabIndex = 4;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.BtnNuevaCarrera1;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(74, 143);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 77);
            btnNuevo.TabIndex = 3;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.ImagenGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(288, 143);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 77);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 14.25F);
            txtDescripcion.Location = new Point(74, 88);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripcion de la Carrera";
            txtDescripcion.Size = new Size(526, 33);
            txtDescripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(74, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de la Carrera";
            txtNombre.Size = new Size(526, 33);
            txtNombre.TabIndex = 0;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarreras.BackgroundColor = Color.RosyBrown;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCarreras.GridColor = Color.RosyBrown;
            dgvCarreras.Location = new Point(74, 430);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(670, 282);
            dgvCarreras.TabIndex = 3;
            dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
            // 
            // txtNombreCarrera
            // 
            txtNombreCarrera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCarrera.Location = new Point(478, 391);
            txtNombreCarrera.Name = "txtNombreCarrera";
            txtNombreCarrera.PlaceholderText = "Buscar Carrera";
            txtNombreCarrera.Size = new Size(266, 33);
            txtNombreCarrera.TabIndex = 4;
            txtNombreCarrera.TextChanged += txtNombreCarrera_TextChanged;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 749);
            Controls.Add(txtNombreCarrera);
            Controls.Add(dgvCarreras);
            Controls.Add(pnlContenedor);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmCarreras";
            Text = "frmCarreras";
            WindowState = FormWindowState.Maximized;
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
        private Button btnNuevo;
        private Button btnBorrar;
        private TextBox txtNombreCarrera;
    }
}