namespace prySistemaEscolar
{
    partial class frmReportes
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
            gpbxOpciones = new GroupBox();
            radioButton1 = new RadioButton();
            rdbtnMostrarAlumRiesgo = new RadioButton();
            pictureBox1 = new PictureBox();
            btnVer = new Button();
            btnGenerarPDF = new Button();
            dgvCarreras = new DataGridView();
            gpbxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).BeginInit();
            SuspendLayout();
            // 
            // gpbxOpciones
            // 
            gpbxOpciones.BackColor = Color.Peru;
            gpbxOpciones.Controls.Add(radioButton1);
            gpbxOpciones.Controls.Add(rdbtnMostrarAlumRiesgo);
            gpbxOpciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbxOpciones.Location = new Point(68, 179);
            gpbxOpciones.Name = "gpbxOpciones";
            gpbxOpciones.Size = new Size(640, 134);
            gpbxOpciones.TabIndex = 0;
            gpbxOpciones.TabStop = false;
            gpbxOpciones.Text = "Opciones";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(20, 78);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(443, 25);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mostrar los tutores de los alumnos con promedios >=9";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdbtnMostrarAlumRiesgo
            // 
            rdbtnMostrarAlumRiesgo.AutoSize = true;
            rdbtnMostrarAlumRiesgo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rdbtnMostrarAlumRiesgo.ForeColor = SystemColors.ActiveCaptionText;
            rdbtnMostrarAlumRiesgo.Location = new Point(20, 29);
            rdbtnMostrarAlumRiesgo.Name = "rdbtnMostrarAlumRiesgo";
            rdbtnMostrarAlumRiesgo.Size = new Size(572, 25);
            rdbtnMostrarAlumRiesgo.TabIndex = 0;
            rdbtnMostrarAlumRiesgo.TabStop = true;
            rdbtnMostrarAlumRiesgo.Text = "Mostrar los alumnos y su carrera con los promedios de Bachillerato <=8";
            rdbtnMostrarAlumRiesgo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pcbReportesTitulo;
            pictureBox1.Location = new Point(67, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(677, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(58, 154, 138);
            btnVer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVer.Location = new Point(313, 319);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(150, 35);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = false;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.BackColor = Color.FromArgb(58, 154, 138);
            btnGenerarPDF.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGenerarPDF.Location = new Point(313, 655);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(150, 35);
            btnGenerarPDF.TabIndex = 4;
            btnGenerarPDF.Text = "Generar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
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
            dgvCarreras.Location = new Point(67, 367);
            dgvCarreras.Name = "dgvCarreras";
            dgvCarreras.Size = new Size(670, 282);
            dgvCarreras.TabIndex = 5;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 711);
            Controls.Add(dgvCarreras);
            Controls.Add(btnGenerarPDF);
            Controls.Add(btnVer);
            Controls.Add(pictureBox1);
            Controls.Add(gpbxOpciones);
            Name = "frmReportes";
            Text = "frmReportes";
            gpbxOpciones.ResumeLayout(false);
            gpbxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarreras).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbxOpciones;
        private RadioButton radioButton1;
        private RadioButton rdbtnMostrarAlumRiesgo;
        private PictureBox pictureBox1;
        private Button btnVer;
        private Button btnGenerarPDF;
        private DataGridView dgvCarreras;
    }
}