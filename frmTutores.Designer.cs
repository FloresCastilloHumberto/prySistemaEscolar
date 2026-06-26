namespace prySistemaEscolar
{
    partial class frmTutores
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            btnBorrar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            txtParentesco = new TextBox();
            txtNombre = new TextBox();
            txtNombreTutor = new TextBox();
            dgvTutores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.LogoTutores;
            pcbLogo.Location = new Point(69, 37);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(78, 73);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 1;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(341, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(132, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Tutores";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(txtCorreo);
            pnlContenedor.Controls.Add(txtDireccion);
            pnlContenedor.Controls.Add(txtTelefono);
            pnlContenedor.Controls.Add(btnBorrar);
            pnlContenedor.Controls.Add(btnNuevo);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(txtParentesco);
            pnlContenedor.Controls.Add(txtNombre);
            pnlContenedor.Location = new Point(69, 127);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(670, 236);
            pnlContenedor.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F);
            txtCorreo.Location = new Point(350, 104);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Escribir correo";
            txtCorreo.Size = new Size(301, 33);
            txtCorreo.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14.25F);
            txtDireccion.Location = new Point(350, 62);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Escribir dirección";
            txtDireccion.Size = new Size(301, 33);
            txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F);
            txtTelefono.Location = new Point(13, 104);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(300, 33);
            txtTelefono.TabIndex = 5;
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
            btnBorrar.Click += btnEliminar_Click;
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
            btnGuardar.Location = new Point(290, 143);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 77);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtParentesco
            // 
            txtParentesco.Font = new Font("Segoe UI", 14.25F);
            txtParentesco.Location = new Point(12, 62);
            txtParentesco.Name = "txtParentesco";
            txtParentesco.PlaceholderText = "Escribir parentesco";
            txtParentesco.Size = new Size(301, 33);
            txtParentesco.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(13, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribir nombre del tutor ";
            txtNombre.Size = new Size(638, 33);
            txtNombre.TabIndex = 0;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(473, 369);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Buscar Tutor";
            txtNombreTutor.Size = new Size(266, 33);
            txtNombreTutor.TabIndex = 5;
            txtNombreTutor.TextChanged += txtNombreTutor_TextChanged;
            // 
            // dgvTutores
            // 
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTutores.BackgroundColor = Color.RosyBrown;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTutores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTutores.GridColor = Color.RosyBrown;
            dgvTutores.Location = new Point(69, 408);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.Size = new Size(670, 259);
            dgvTutores.TabIndex = 6;
            dgvTutores.SelectionChanged += dgvTutores_SelectionChanged;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 749);
            Controls.Add(dgvTutores);
            Controls.Add(txtNombreTutor);
            Controls.Add(pnlContenedor);
            Controls.Add(lblTitulo);
            Controls.Add(pcbLogo);
            DoubleBuffered = true;
            Name = "frmTutores";
            Text = "frmTutores";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Panel pnlContenedor;
        private Button btnBorrar;
        private Button btnNuevo;
        private Button btnGuardar;
        private TextBox txtParentesco;
        private TextBox txtNombre;
        private TextBox txtNombreTutor;
        private DataGridView dgvTutores;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
    }
}