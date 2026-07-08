namespace prySistemaEscolar
{
    partial class frmDocentes
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
            label2 = new Label();
            label1 = new Label();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            pnlAlumno = new Panel();
            txtClave = new TextBox();
            txtNombre = new TextBox();
            txtPuesto = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtClaveDocente = new TextBox();
            dgvDocentes = new DataGridView();
            btnBorrar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlUsuario.SuspendLayout();
            pnlAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.profesor;
            pcbLogo.Location = new Point(265, 30);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(80, 77);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 24;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(351, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(158, 45);
            lblTitulo.TabIndex = 23;
            lblTitulo.Text = "Docentes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(506, 118);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 22;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 118);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 25;
            label1.Text = "Docente";
            // 
            // pnlUsuario
            // 
            pnlUsuario.BackColor = SystemColors.MenuHighlight;
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(506, 142);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(287, 143);
            pnlUsuario.TabIndex = 27;
            // 
            // cmbPerfil
            // 
            cmbPerfil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cmbPerfil.FormattingEnabled = true;
            cmbPerfil.Items.AddRange(new object[] { "Administrador", "Alumno", "Docente", "Tutor" });
            cmbPerfil.Location = new Point(37, 78);
            cmbPerfil.Name = "cmbPerfil";
            cmbPerfil.Size = new Size(223, 28);
            cmbPerfil.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtPassword.Location = new Point(37, 45);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(223, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtUsuario.Location = new Point(37, 12);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(223, 27);
            txtUsuario.TabIndex = 13;
            // 
            // pnlAlumno
            // 
            pnlAlumno.BackColor = SystemColors.MenuHighlight;
            pnlAlumno.Controls.Add(txtClave);
            pnlAlumno.Controls.Add(txtNombre);
            pnlAlumno.Controls.Add(txtPuesto);
            pnlAlumno.Controls.Add(txtTelefono);
            pnlAlumno.Controls.Add(txtCorreo);
            pnlAlumno.Location = new Point(24, 142);
            pnlAlumno.Name = "pnlAlumno";
            pnlAlumno.Size = new Size(476, 143);
            pnlAlumno.TabIndex = 26;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtClave.Location = new Point(11, 12);
            txtClave.Name = "txtClave";
            txtClave.PlaceholderText = "Clave";
            txtClave.Size = new Size(223, 27);
            txtClave.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtNombre.Location = new Point(10, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(452, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtPuesto.Location = new Point(239, 12);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.PlaceholderText = "Puesto";
            txtPuesto.Size = new Size(223, 27);
            txtPuesto.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtTelefono.Location = new Point(11, 78);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(223, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtCorreo.Location = new Point(239, 78);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(223, 27);
            txtCorreo.TabIndex = 7;
            // 
            // txtClaveDocente
            // 
            txtClaveDocente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClaveDocente.Location = new Point(483, 399);
            txtClaveDocente.Name = "txtClaveDocente";
            txtClaveDocente.PlaceholderText = "Buscar por clave";
            txtClaveDocente.Size = new Size(266, 33);
            txtClaveDocente.TabIndex = 32;
            txtClaveDocente.TextChanged += txtClaveDocente_TextChanged;
            // 
            // dgvDocentes
            // 
            dgvDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocentes.BackgroundColor = Color.Gray;
            dgvDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDocentes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvDocentes.GridColor = Color.RosyBrown;
            dgvDocentes.Location = new Point(79, 438);
            dgvDocentes.Name = "dgvDocentes";
            dgvDocentes.Size = new Size(670, 199);
            dgvDocentes.TabIndex = 31;
            dgvDocentes.SelectionChanged += dgvDocentes_SelectionChanged;
            // 
            // btnBorrar
            // 
            btnBorrar.BackgroundImage = Properties.Resources.BtnBorrarCarrera1;
            btnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorrar.Location = new Point(564, 303);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(117, 77);
            btnBorrar.TabIndex = 30;
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.BtnNuevaCarrera1;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(155, 303);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 77);
            btnNuevo.TabIndex = 29;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.ImagenGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(369, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 77);
            btnGuardar.TabIndex = 28;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 701);
            Controls.Add(txtClaveDocente);
            Controls.Add(dgvDocentes);
            Controls.Add(btnBorrar);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlAlumno);
            Controls.Add(label1);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "frmDocentes";
            Text = "frmDocentes";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTitulo;
        private Label label2;
        private Label label1;
        private Panel pnlUsuario;
        private ComboBox cmbPerfil;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Panel pnlAlumno;
        private TextBox txtClave;
        private TextBox txtNombre;
        private TextBox txtPuesto;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtClaveDocente;
        private DataGridView dgvDocentes;
        private Button btnBorrar;
        private Button btnNuevo;
        private Button btnGuardar;
    }
}