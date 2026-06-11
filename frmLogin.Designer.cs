namespace prySistemaEscolar
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pcbLoginFondo = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pcbLoginIcono = new PictureBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLoginIcono).BeginInit();
            SuspendLayout();
            // 
            // pcbLoginFondo
            // 
            pcbLoginFondo.Image = (Image)resources.GetObject("pcbLoginFondo.Image");
            pcbLoginFondo.Location = new Point(36, 29);
            pcbLoginFondo.Margin = new Padding(3, 2, 3, 2);
            pcbLoginFondo.Name = "pcbLoginFondo";
            pcbLoginFondo.Size = new Size(231, 221);
            pcbLoginFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginFondo.TabIndex = 0;
            pcbLoginFondo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtUsuario.ForeColor = SystemColors.WindowText;
            txtUsuario.Location = new Point(343, 83);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(247, 29);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold);
            txtPassword.ForeColor = SystemColors.WindowText;
            txtPassword.Location = new Point(343, 130);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña del usuario";
            txtPassword.Size = new Size(247, 29);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pcbLoginIcono
            // 
            pcbLoginIcono.BackColor = Color.Transparent;
            pcbLoginIcono.Image = (Image)resources.GetObject("pcbLoginIcono.Image");
            pcbLoginIcono.Location = new Point(709, 11);
            pcbLoginIcono.Margin = new Padding(3, 2, 3, 2);
            pcbLoginIcono.Name = "pcbLoginIcono";
            pcbLoginIcono.Size = new Size(103, 95);
            pcbLoginIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginIcono.TabIndex = 3;
            pcbLoginIcono.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Cascadia Mono SemiBold", 10.8F, FontStyle.Bold);
            btnAcceder.Location = new Point(343, 200);
            btnAcceder.Margin = new Padding(3, 2, 3, 2);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(119, 34);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Cascadia Mono SemiBold", 10.8F, FontStyle.Bold);
            btnSalir.Location = new Point(471, 200);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 34);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 291);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(pcbLoginIcono);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLoginFondo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "Control de Acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLoginIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLoginFondo;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox pcbLoginIcono;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
