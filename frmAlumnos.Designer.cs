namespace prySistemaEscolar
{
    partial class frmAlumnos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtMatricula = new TextBox();
            txtNombre = new TextBox();
            txtAPaterno = new TextBox();
            txtAMaterno = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPromedioBachillerato = new TextBox();
            cmbTutor = new ComboBox();
            cmbCarrera = new ComboBox();
            pnlAlumno = new Panel();
            pnlUsuario = new Panel();
            cmbPerfil = new ComboBox();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnBorrar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            txtNombreAlumno = new TextBox();
            dgvCarreras = new DataGridView();
            lblTitulo = new Label();
            pcbLogo = new PictureBox();
            pnlAlumno.SuspendLayout();
            pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtMatricula
            // 
            txtMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtMatricula.Location = new Point(10, 11);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PlaceholderText = "Matricula";
            txtMatricula.Size = new Size(223, 27);
            txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtNombre.Location = new Point(10, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(223, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtAPaterno
            // 
            txtAPaterno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtAPaterno.Location = new Point(10, 77);
            txtAPaterno.Name = "txtAPaterno";
            txtAPaterno.PlaceholderText = "Apellido Paterno";
            txtAPaterno.Size = new Size(223, 27);
            txtAPaterno.TabIndex = 3;
            // 
            // txtAMaterno
            // 
            txtAMaterno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtAMaterno.Location = new Point(10, 110);
            txtAMaterno.Name = "txtAMaterno";
            txtAMaterno.PlaceholderText = "Apellido Materno";
            txtAMaterno.Size = new Size(223, 27);
            txtAMaterno.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtDireccion.Location = new Point(10, 143);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PlaceholderText = "Direccion";
            txtDireccion.Size = new Size(223, 27);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtTelefono.Location = new Point(240, 11);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(223, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtCorreo.Location = new Point(239, 44);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(223, 27);
            txtCorreo.TabIndex = 7;
            // 
            // txtPromedioBachillerato
            // 
            txtPromedioBachillerato.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtPromedioBachillerato.Location = new Point(240, 77);
            txtPromedioBachillerato.Name = "txtPromedioBachillerato";
            txtPromedioBachillerato.PlaceholderText = "Promedio Bachillerato";
            txtPromedioBachillerato.Size = new Size(223, 27);
            txtPromedioBachillerato.TabIndex = 8;
            // 
            // cmbTutor
            // 
            cmbTutor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cmbTutor.FormattingEnabled = true;
            cmbTutor.Location = new Point(240, 109);
            cmbTutor.Name = "cmbTutor";
            cmbTutor.Size = new Size(223, 28);
            cmbTutor.TabIndex = 9;
            cmbTutor.SelectedIndexChanged += cmbTutor_SelectedIndexChanged;
            // 
            // cmbCarrera
            // 
            cmbCarrera.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(240, 142);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(223, 28);
            cmbCarrera.TabIndex = 10;
            // 
            // pnlAlumno
            // 
            pnlAlumno.Controls.Add(txtMatricula);
            pnlAlumno.Controls.Add(txtNombre);
            pnlAlumno.Controls.Add(txtAPaterno);
            pnlAlumno.Controls.Add(cmbCarrera);
            pnlAlumno.Controls.Add(txtPromedioBachillerato);
            pnlAlumno.Controls.Add(txtAMaterno);
            pnlAlumno.Controls.Add(cmbTutor);
            pnlAlumno.Controls.Add(txtDireccion);
            pnlAlumno.Controls.Add(txtTelefono);
            pnlAlumno.Controls.Add(txtCorreo);
            pnlAlumno.Location = new Point(20, 111);
            pnlAlumno.Name = "pnlAlumno";
            pnlAlumno.Size = new Size(476, 201);
            pnlAlumno.TabIndex = 11;
            pnlAlumno.Paint += pnlAlumno_Paint;
            // 
            // pnlUsuario
            // 
            pnlUsuario.Controls.Add(cmbPerfil);
            pnlUsuario.Controls.Add(txtPassword);
            pnlUsuario.Controls.Add(txtUsuario);
            pnlUsuario.Location = new Point(502, 111);
            pnlUsuario.Name = "pnlUsuario";
            pnlUsuario.Size = new Size(287, 201);
            pnlUsuario.TabIndex = 12;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 87);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 13;
            label1.Text = "Alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(502, 87);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 14;
            label2.Text = "Usuario";
            // 
            // btnBorrar
            // 
            btnBorrar.BackgroundImage = Properties.Resources.BtnBorrarCarrera1;
            btnBorrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorrar.Location = new Point(568, 329);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(117, 77);
            btnBorrar.TabIndex = 17;
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImage = Properties.Resources.BtnNuevaCarrera1;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.Location = new Point(159, 329);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(147, 77);
            btnNuevo.TabIndex = 16;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.ImagenGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(373, 329);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(123, 77);
            btnGuardar.TabIndex = 15;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtNombreAlumno
            // 
            txtNombreAlumno.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreAlumno.Location = new Point(487, 412);
            txtNombreAlumno.Name = "txtNombreAlumno";
            txtNombreAlumno.PlaceholderText = "Buscar Alumno";
            txtNombreAlumno.Size = new Size(266, 33);
            txtNombreAlumno.TabIndex = 19;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarreras.BackgroundColor = Color.RosyBrown;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarreras.GridColor = Color.RosyBrown;
            dgvCarreras.Location = new Point(83, 455);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(670, 282);
            dgvCarreras.TabIndex = 18;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(343, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(153, 45);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Alumnos";
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.LogoAalumn;
            pcbLogo.Location = new Point(257, 31);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(80, 74);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 21;
            pcbLogo.TabStop = false;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 749);
            Controls.Add(pcbLogo);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombreAlumno);
            Controls.Add(dgvCarreras);
            Controls.Add(btnBorrar);
            Controls.Add(label2);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(pnlUsuario);
            Controls.Add(pnlAlumno);
            DoubleBuffered = true;
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            Load += frmAlumnos_Load;
            pnlAlumno.ResumeLayout(false);
            pnlAlumno.PerformLayout();
            pnlUsuario.ResumeLayout(false);
            pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatricula;
        private TextBox txtNombre;
        private TextBox txtAPaterno;
        private TextBox txtAMaterno;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPromedioBachillerato;
        private ComboBox cmbTutor;
        private ComboBox cmbCarrera;
        private Panel pnlAlumno;
        private Panel pnlUsuario;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private ComboBox cmbPerfil;
        private Label label1;
        private Label label2;
        private Button btnBorrar;
        private Button btnNuevo;
        private Button btnGuardar;
        private TextBox txtNombreAlumno;
        private DataGridView dgvCarreras;
        private Label lblTitulo;
        private PictureBox pcbLogo;
    }
}