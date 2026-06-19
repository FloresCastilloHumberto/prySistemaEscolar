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
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            dgvCarreras = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            pcbLogo.Size = new Size(177, 168);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(494, 118);
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
            pnlContenedor.Location = new Point(266, 198);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(584, 215);
            pnlContenedor.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.ImagenGuardar;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.Location = new Point(228, 133);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 79);
            btnGuardar.TabIndex = 2;
            btnGuardar.UseVisualStyleBackColor = true;
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
            dgvCarreras.Location = new Point(266, 433);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(584, 74);
            dgvCarreras.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(707, 70);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 4;
            label1.Text = "dasdasdaasdasdasda";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.BtnNuevaCarrera1;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(73, 133);
            button1.Name = "button1";
            button1.Size = new Size(105, 79);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.BtnBorrarCarrera1;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(389, 133);
            button2.Name = "button2";
            button2.Size = new Size(119, 82);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // frmCarreras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1226, 547);
            Controls.Add(label1);
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
        private Button btnGuardar;
        private DataGridView dgvCarreras;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}