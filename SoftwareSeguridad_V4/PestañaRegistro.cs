using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSeguridad_V4
{
    public partial class PestañaRegistro : Form
    {
        public PestañaRegistro()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            SoftwareSeguridad softwareSeguridad = new SoftwareSeguridad();
            softwareSeguridad.Show();
            this.Close();
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.White;
            }
        }
        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuario";
                textBoxUsuario.ForeColor = Color.Gainsboro;
            }
        }
        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "Contraseña")
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.ForeColor = Color.White;
            }
        }

        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                textBoxContraseña.Text = "Contraseña";
                textBoxContraseña.ForeColor = Color.Gainsboro;
            }
        }

        private void textBoxLlave_Enter(object sender, EventArgs e)
        {
            if (textBoxLlave.Text == "IngreseLlave")
            {
                textBoxLlave.Text = "";
                textBoxLlave.ForeColor = Color.White;
            }
        }

        private void textBoxLlave_Leave(object sender, EventArgs e)
        {
            if (textBoxLlave.Text == "")
            {
                textBoxLlave.Text = "IngreseLlave";
                textBoxLlave.ForeColor = Color.Gainsboro;
            }
        }

        private void VolverAlLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PestañaLogin register = new PestañaLogin();
            register.Show();
            this.Close();
        }
    }
}
