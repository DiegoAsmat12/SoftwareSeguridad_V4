namespace SoftwareSeguridad_V4
{
    partial class VistaMapa
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
            this.gMapControlUbicaciones = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gMapControlUbicaciones
            // 
            this.gMapControlUbicaciones.Bearing = 0F;
            this.gMapControlUbicaciones.CanDragMap = true;
            this.gMapControlUbicaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControlUbicaciones.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlUbicaciones.GrayScaleMode = false;
            this.gMapControlUbicaciones.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlUbicaciones.LevelsKeepInMemory = 5;
            this.gMapControlUbicaciones.Location = new System.Drawing.Point(0, 0);
            this.gMapControlUbicaciones.MarkersEnabled = true;
            this.gMapControlUbicaciones.MaxZoom = 2;
            this.gMapControlUbicaciones.MinZoom = 2;
            this.gMapControlUbicaciones.MouseWheelZoomEnabled = true;
            this.gMapControlUbicaciones.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlUbicaciones.Name = "gMapControlUbicaciones";
            this.gMapControlUbicaciones.NegativeMode = false;
            this.gMapControlUbicaciones.PolygonsEnabled = true;
            this.gMapControlUbicaciones.RetryLoadTile = 0;
            this.gMapControlUbicaciones.RoutesEnabled = true;
            this.gMapControlUbicaciones.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlUbicaciones.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlUbicaciones.ShowTileGridLines = false;
            this.gMapControlUbicaciones.Size = new System.Drawing.Size(1184, 792);
            this.gMapControlUbicaciones.TabIndex = 1;
            this.gMapControlUbicaciones.Zoom = 0D;
            // 
            // VistaMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1184, 792);
            this.Controls.Add(this.gMapControlUbicaciones);
            this.Name = "VistaMapa";
            this.Text = "VistaMapa";
            this.Load += new System.EventHandler(this.VistaMapa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControlUbicaciones;
    }
}