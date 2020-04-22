namespace SoftwareSeguridad_V4
{
    partial class VistaSeguimiento
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
            this.splitContainerCamaraySelector = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoViewerWFRenderizador = new Ozeki.Media.Video.Controls.VideoViewerWF();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxCamara = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCamaraySelector)).BeginInit();
            this.splitContainerCamaraySelector.Panel1.SuspendLayout();
            this.splitContainerCamaraySelector.Panel2.SuspendLayout();
            this.splitContainerCamaraySelector.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerCamaraySelector
            // 
            this.splitContainerCamaraySelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCamaraySelector.Location = new System.Drawing.Point(0, 0);
            this.splitContainerCamaraySelector.Name = "splitContainerCamaraySelector";
            this.splitContainerCamaraySelector.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerCamaraySelector.Panel1
            // 
            this.splitContainerCamaraySelector.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainerCamaraySelector.Panel2
            // 
            this.splitContainerCamaraySelector.Panel2.Controls.Add(this.panel2);
            this.splitContainerCamaraySelector.Panel2MinSize = 0;
            this.splitContainerCamaraySelector.Size = new System.Drawing.Size(1184, 792);
            this.splitContainerCamaraySelector.SplitterDistance = 693;
            this.splitContainerCamaraySelector.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoViewerWFRenderizador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 693);
            this.panel1.TabIndex = 0;
            // 
            // videoViewerWFRenderizador
            // 
            this.videoViewerWFRenderizador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.videoViewerWFRenderizador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoViewerWFRenderizador.FlipMode = Ozeki.Media.Video.FlipMode.None;
            this.videoViewerWFRenderizador.Location = new System.Drawing.Point(0, 0);
            this.videoViewerWFRenderizador.Name = "videoViewerWFRenderizador";
            this.videoViewerWFRenderizador.RotateAngle = 0;
            this.videoViewerWFRenderizador.Size = new System.Drawing.Size(1184, 693);
            this.videoViewerWFRenderizador.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxCamara);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 95);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxCamara
            // 
            this.comboBoxCamara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCamara.FormattingEnabled = true;
            this.comboBoxCamara.Items.AddRange(new object[] {
            "SeleccioneCámara",
            "Camara1",
            "Camara2",
            "Camara3",
            "Camara4",
            "Camara5",
            "Camara6"});
            this.comboBoxCamara.Location = new System.Drawing.Point(365, 40);
            this.comboBoxCamara.Name = "comboBoxCamara";
            this.comboBoxCamara.Size = new System.Drawing.Size(348, 21);
            this.comboBoxCamara.TabIndex = 0;
            this.comboBoxCamara.SelectedIndexChanged += new System.EventHandler(this.comboBoxCamara_SelectedIndexChanged);
            // 
            // VistaSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1184, 792);
            this.Controls.Add(this.splitContainerCamaraySelector);
            this.Name = "VistaSeguimiento";
            this.Text = "VistaSeguimiento";
            this.Load += new System.EventHandler(this.VistaSeguimiento_Load);
            this.splitContainerCamaraySelector.Panel1.ResumeLayout(false);
            this.splitContainerCamaraySelector.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCamaraySelector)).EndInit();
            this.splitContainerCamaraySelector.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerCamaraySelector;
        private System.Windows.Forms.Panel panel1;
        private Ozeki.Media.Video.Controls.VideoViewerWF videoViewerWFRenderizador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCamara;
    }
}