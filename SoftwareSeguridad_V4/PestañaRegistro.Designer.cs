namespace SoftwareSeguridad_V4
{
    partial class PestañaRegistro
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.VolverAlLogin = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxLlave = new System.Windows.Forms.TextBox();
            this.panelCambioDePestañas = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonPestañaLogin = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonRegistrarse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCandado = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelCambioDePestañas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelContenedor.Controls.Add(this.VolverAlLogin);
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Controls.Add(this.panel3);
            this.panelContenedor.Controls.Add(this.textBoxLlave);
            this.panelContenedor.Controls.Add(this.panelCambioDePestañas);
            this.panelContenedor.Controls.Add(this.panelLogo);
            this.panelContenedor.Controls.Add(this.buttonRegistrarse);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Controls.Add(this.pictureBoxCandado);
            this.panelContenedor.Controls.Add(this.panel2);
            this.panelContenedor.Controls.Add(this.textBoxContraseña);
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Controls.Add(this.textBoxUsuario);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(800, 450);
            this.panelContenedor.TabIndex = 6;
            // 
            // VolverAlLogin
            // 
            this.VolverAlLogin.AutoSize = true;
            this.VolverAlLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverAlLogin.LinkColor = System.Drawing.Color.Gainsboro;
            this.VolverAlLogin.Location = new System.Drawing.Point(334, 407);
            this.VolverAlLogin.Name = "VolverAlLogin";
            this.VolverAlLogin.Size = new System.Drawing.Size(399, 20);
            this.VolverAlLogin.TabIndex = 13;
            this.VolverAlLogin.TabStop = true;
            this.VolverAlLogin.Text = "¿Ya tienes una cuenta?, Volver a la pestaña de ingreso";
            this.VolverAlLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VolverAlLogin_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(382, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 1);
            this.panel3.TabIndex = 10;
            // 
            // textBoxLlave
            // 
            this.textBoxLlave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.textBoxLlave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLlave.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxLlave.Location = new System.Drawing.Point(382, 275);
            this.textBoxLlave.Name = "textBoxLlave";
            this.textBoxLlave.Size = new System.Drawing.Size(288, 33);
            this.textBoxLlave.TabIndex = 11;
            this.textBoxLlave.Text = "IngreseLlave";
            this.textBoxLlave.UseSystemPasswordChar = true;
            this.textBoxLlave.Enter += new System.EventHandler(this.textBoxLlave_Enter);
            this.textBoxLlave.Leave += new System.EventHandler(this.textBoxLlave_Leave);
            // 
            // panelCambioDePestañas
            // 
            this.panelCambioDePestañas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panelCambioDePestañas.Controls.Add(this.buttonMinimize);
            this.panelCambioDePestañas.Controls.Add(this.buttonPestañaLogin);
            this.panelCambioDePestañas.Controls.Add(this.buttonClose);
            this.panelCambioDePestañas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCambioDePestañas.Location = new System.Drawing.Point(264, 0);
            this.panelCambioDePestañas.Name = "panelCambioDePestañas";
            this.panelCambioDePestañas.Size = new System.Drawing.Size(536, 49);
            this.panelCambioDePestañas.TabIndex = 9;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonMinimize.Location = new System.Drawing.Point(484, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(28, 27);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.Text = "-";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonPestañaLogin
            // 
            this.buttonPestañaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonPestañaLogin.FlatAppearance.BorderSize = 0;
            this.buttonPestañaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPestañaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPestañaLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPestañaLogin.Location = new System.Drawing.Point(-2, 12);
            this.buttonPestañaLogin.Name = "buttonPestañaLogin";
            this.buttonPestañaLogin.Size = new System.Drawing.Size(128, 37);
            this.buttonPestañaLogin.TabIndex = 1;
            this.buttonPestañaLogin.Text = "Registro";
            this.buttonPestañaLogin.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonClose.Location = new System.Drawing.Point(508, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(28, 27);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(264, 450);
            this.panelLogo.TabIndex = 8;
            // 
            // buttonRegistrarse
            // 
            this.buttonRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonRegistrarse.FlatAppearance.BorderSize = 0;
            this.buttonRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarse.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRegistrarse.Location = new System.Drawing.Point(432, 352);
            this.buttonRegistrarse.Name = "buttonRegistrarse";
            this.buttonRegistrarse.Size = new System.Drawing.Size(202, 37);
            this.buttonRegistrarse.TabIndex = 6;
            this.buttonRegistrarse.Text = "Registrarse";
            this.buttonRegistrarse.UseVisualStyleBackColor = false;
            this.buttonRegistrarse.Click += new System.EventHandler(this.buttonRegistrarse_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(382, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 1);
            this.panel2.TabIndex = 3;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxContraseña.Location = new System.Drawing.Point(382, 184);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(288, 33);
            this.textBoxContraseña.TabIndex = 3;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.Enter += new System.EventHandler(this.textBoxContraseña_Enter);
            this.textBoxContraseña.Leave += new System.EventHandler(this.textBoxContraseña_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(382, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 1);
            this.panel1.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsuario.Location = new System.Drawing.Point(382, 99);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(294, 33);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "Usuario";
            this.textBoxUsuario.Enter += new System.EventHandler(this.textBoxUsuario_Enter);
            this.textBoxUsuario.Leave += new System.EventHandler(this.textBoxUsuario_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SoftwareSeguridad_V4.Properties.Resources.IconoLlave;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(311, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 44);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SoftwareSeguridad_V4.Properties.Resources.IconoUsuario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(311, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxCandado
            // 
            this.pictureBoxCandado.BackgroundImage = global::SoftwareSeguridad_V4.Properties.Resources.IconoCandado;
            this.pictureBoxCandado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCandado.Location = new System.Drawing.Point(311, 173);
            this.pictureBoxCandado.Name = "pictureBoxCandado";
            this.pictureBoxCandado.Size = new System.Drawing.Size(40, 44);
            this.pictureBoxCandado.TabIndex = 4;
            this.pictureBoxCandado.TabStop = false;
            // 
            // PestañaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PestañaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PestañaRegistro";
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelCambioDePestañas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCandado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.LinkLabel VolverAlLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxLlave;
        private System.Windows.Forms.Panel panelCambioDePestañas;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonPestañaLogin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonRegistrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxCandado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUsuario;
    }
}