using GMap.NET;
using GMap.NET.MapProviders;
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
    public partial class VistaMapa : Form
    {
        public VistaMapa()
        {
            InitializeComponent();
        }
        private void CargarMapa()
        {

            gMapControlUbicaciones.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControlUbicaciones.Position = new PointLatLng(-12.1470976, -76.9982464);
            gMapControlUbicaciones.MinZoom = 15;
            gMapControlUbicaciones.MaxZoom = 27;
            gMapControlUbicaciones.Zoom = 18;
            gMapControlUbicaciones.CanDragMap = true;
            gMapControlUbicaciones.ShowCenter = false;


        }

        private void VistaMapa_Load(object sender, EventArgs e)
        {
            CargarMapa();
        }
    }
}
