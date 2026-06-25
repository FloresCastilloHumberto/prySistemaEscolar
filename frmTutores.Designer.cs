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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pcbLogo = new PictureBox();
            lblTitulo = new Label();
            pnlContenedor = new Panel();
            btnBorrar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            txtNombreTutor = new TextBox();
            dgvCarreras = new DataGridView();
            txtTelefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.LogoTutores;
            pcbLogo.Location = new Point(56, 37);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(130, 115);
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
            pnlContenedor.Controls.Add(txtTelefono);
            pnlContenedor.Controls.Add(btnBorrar);
            pnlContenedor.Controls.Add(btnNuevo);
            pnlContenedor.Controls.Add(btnGuardar);
            pnlContenedor.Controls.Add(txtCorreo);
            pnlContenedor.Controls.Add(txtNombre);
            pnlContenedor.Location = new Point(69, 169);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(670, 236);
            pnlContenedor.TabIndex = 3;
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
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14.25F);
            txtCorreo.Location = new Point(12, 62);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo";
            txtCorreo.Size = new Size(526, 33);
            txtCorreo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(13, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del tutor ";
            txtNombre.Size = new Size(442, 33);
            txtNombre.TabIndex = 0;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(473, 420);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Buscar Tutor";
            txtNombreTutor.Size = new Size(266, 33);
            txtNombreTutor.TabIndex = 5;
            // 
            // dgvCarreras
            // 
            dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarreras.BackgroundColor = Color.RosyBrown;
            dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCarreras.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCarreras.GridColor = Color.RosyBrown;
            dgvCarreras.Location = new Point(69, 459);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(670, 259);
            dgvCarreras.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14.25F);
            txtTelefono.Location = new Point(460, 14);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "Telefono";
            txtTelefono.Size = new Size(197, 33);
            txtTelefono.TabIndex = 5;
            // 
            // frmTutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(815, 749);
            Controls.Add(dgvCarreras);
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
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
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
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private TextBox txtNombreTutor;
        private DataGridView dgvCarreras;
        private TextBox txtTelefono;
    }
}