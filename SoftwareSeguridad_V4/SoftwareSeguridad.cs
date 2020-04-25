using Ozeki.Media.IPCamera;
using System;
using System.CodeDom;
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
    public partial class SoftwareSeguridad : Form
    {
        public Image imagenOriginalBotonExpandir;
        public VistaCamaras vistaCamaras;
        public VistaSeguimiento vistaSeguimiento;
        public VistaMapa vistaMapa;
        public SoftwareSeguridad()
        {
            InitializeComponent();
        }
        private void SoftwareSeguridad_Load(object sender, EventArgs e)
        {
            panelOpcionesInicio.Height = 0;
            panelOpcionesDeInformacion1.Hide();
            panelOpcionesDeInformacion2.Hide();
            splitContainerInformacion.SplitterDistance = panelInformacion.Height;
            AbrirFormularioVistas<VistaCamaras>(panelVistas);
            AbrirFormularioVistas<VistaSeguimiento>(panelVistas);
            AbrirFormularioVistas<VistaMapa>(panelVistas);
            buttonVistaCamaras.BackColor = Color.FromArgb(80, 80, 80);
            AbrirFormularioVistas<InfoTablaCamaras>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaPlacas>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaListaNegra>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaSerenazgos>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaCamaras>(panelInfoForm2);
            AbrirFormularioVistas<InfoTablaPlacas>(panelInfoForm2);
            AbrirFormularioVistas<InfoTablaListaNegra>(panelInfoForm2);
            AbrirFormularioVistas<InfoTablaSerenazgos>(panelInfoForm2);


            //imagenOriginalBotonExpandir = buttonExpandirContraer.BackgroundImage;
            //splitContainerHerramientas.Panel1Collapsed = true;
        }
        private void AbrirFormularioVistas<MiForm>(Panel panel) where MiForm:Form,new()
        {
            
                Form formulario;
                formulario = panel.Controls.OfType<MiForm>().FirstOrDefault();
                if (formulario == null)
                {
                    formulario = new MiForm();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    panel.Controls.Add(formulario);
                    panel.Tag = formulario;
                    formulario.Show();

                }
                else
                {
                    formulario.BringToFront();
                }
        }
        private void panelOpcionesInicio_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(panelOpcionesInicio, e);
            using (Brush b = new SolidBrush(Color.FromArgb(150, panelOpcionesInicio.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
                
            }
            PaintTransparentBackground(panelOpcionesDeInformacion1, e);
            using (Brush b = new SolidBrush(Color.FromArgb(150, panelOpcionesInicio.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
            PaintTransparentBackground(panelOpcionesDeInformacion2, e);
            using (Brush b = new SolidBrush(Color.FromArgb(150, panelOpcionesInicio.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void buttonOpcionesInicio_Click(object sender, EventArgs e)
        {
            if (panelOpcionesInicio.Height == 0)
            {
                panelOpcionesInicio.Height = 75;
            }
            else
            {
                panelOpcionesInicio.Height = 0;
            }

        }

        private void buttonVistaCamaras_MouseEnter(object sender, EventArgs e)
        {
            buttonVistaCamaras.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void buttonVistaCamaras_MouseLeave(object sender, EventArgs e)
        {
            buttonVistaCamaras.BackColor = Color.FromArgb(50, 50, 50);
        }
        private void buttonVistaSeguimiento_MouseEnter(object sender, EventArgs e)
        {
            buttonVistaCamaras.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void buttonVistaSeguimiento_MouseLeave(object sender, EventArgs e)
        {
            buttonVistaCamaras.BackColor = Color.FromArgb(50, 50, 50);
        }
        private void buttonVistaMapa_MouseEnter(object sender, EventArgs e)
        {
            buttonVistaCamaras.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void buttonVistaMapa_MouseLeave(object sender, EventArgs e)
        {
            buttonVistaCamaras.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void buttonSeleccionDeInfo1_Click(object sender, EventArgs e)
        {
            if (panelOpcionesDeInformacion1.Visible==false)
            {
                panelOpcionesDeInformacion1.Show();
                panelOpcionesDeInformacion1.BringToFront();
            }
            else
            {
                panelOpcionesDeInformacion1.Hide();
            }
        }

        private void buttonSeleccionDeInfo2_Click(object sender, EventArgs e)
        {
            if (panelOpcionesDeInformacion2.Visible == false)
            {
                panelOpcionesDeInformacion2.Show();
                panelOpcionesDeInformacion2.BringToFront();
            }
            else
            {
                panelOpcionesDeInformacion2.Hide();
            }
        }

        private void buttonVistaCamaras_Click(object sender, EventArgs e)
        {
            AbrirFormularioVistas<VistaCamaras>(panelVistas);
            AbrirFormularioVistas<InfoTablaCamaras>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaCamaras>(panelInfoForm2);
            panelOpcionesDeInformacion1.Height = 0;
            panelOpcionesDeInformacion2.Height = 0;
            splitContainerInformacion.SplitterDistance = this.Height;
            buttonVistaCamaras.BackColor = Color.FromArgb(80, 80, 80);
            buttonVistaSeguimiento.BackColor = Color.FromArgb(50, 50, 50);
            buttonVistaMapa.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void buttonVistaSeguimiento_Click(object sender, EventArgs e)
        {
            AbrirFormularioVistas<VistaSeguimiento>(panelVistas);
            AbrirFormularioVistas<InfoTablaPlacas>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaPlacas>(panelInfoForm2);
            panelOpcionesDeInformacion1.Hide();
            panelOpcionesDeInformacion2.Hide();
            splitContainerInformacion.SplitterDistance = this.Height;
            buttonVistaSeguimiento.BackColor = Color.FromArgb(80, 80, 80);
            buttonVistaCamaras.BackColor = Color.FromArgb(50, 50, 50);
            buttonVistaMapa.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void buttonVistaMapa_Click(object sender, EventArgs e)
        {
            AbrirFormularioVistas<VistaMapa>(panelVistas);
            AbrirFormularioVistas<InfoTablaListaNegra>(panelInfoForm1);
            AbrirFormularioVistas<InfoTablaSerenazgos>(panelInfoForm2);
            panelOpcionesDeInformacion1.Hide();
            panelOpcionesDeInformacion2.Hide();
            splitContainerInformacion.SplitterDistance = 469;
            buttonVistaMapa.BackColor = Color.FromArgb(80, 80, 80);
            buttonVistaCamaras.BackColor = Color.FromArgb(50, 50, 50);
            buttonVistaSeguimiento.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void buttonTablaCamaras1_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion1.Hide();
            AbrirFormularioVistas<InfoTablaCamaras>(panelInfoForm1);
        }

        private void buttonTablaPlacas1_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion1.Hide();
            AbrirFormularioVistas<InfoTablaPlacas>(panelInfoForm1);
        }

        private void buttonTablaListaNegra1_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion1.Hide();
            AbrirFormularioVistas<InfoTablaListaNegra>(panelInfoForm1);
        }

        private void buttonTablaSerenazgos1_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion1.Hide();
            AbrirFormularioVistas<InfoTablaSerenazgos>(panelInfoForm1);
        }

        private void buttonTablaCamaras2_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion2.Hide();
            AbrirFormularioVistas<InfoTablaCamaras>(panelInfoForm2);
        }

        private void buttonTablaPlacas2_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion2.Hide();
            AbrirFormularioVistas<InfoTablaPlacas>(panelInfoForm2);
        }

        private void buttonTablaListaNegra2_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion2.Hide();
            AbrirFormularioVistas<InfoTablaListaNegra>(panelInfoForm2);
        }

        private void buttonTablaSerenazgos2_Click(object sender, EventArgs e)
        {
            panelOpcionesDeInformacion2.Hide();
            AbrirFormularioVistas<InfoTablaSerenazgos>(panelInfoForm2);
        }

        


        /*private void buttonExpandirContraer_Click(object sender, EventArgs e)
        {
            if (buttonExpandirContraer.BackgroundImage == imagenOriginalBotonExpandir)
            {
                splitContainerHerramientas.Panel1Collapsed = false;
                buttonExpandirContraer.BackgroundImage = Properties.Resources.FlechaContraer;
            }
            else
            {
                splitContainerHerramientas.Panel1Collapsed = true;
                buttonExpandirContraer.BackgroundImage = imagenOriginalBotonExpandir;
            }

        }*/


    }
}
