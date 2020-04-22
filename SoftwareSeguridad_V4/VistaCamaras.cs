using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ozeki.Media.IPCamera;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.Video;
using Ozeki.Media.Video.Controls;


namespace SoftwareSeguridad_V4
{
    
    public partial class VistaCamaras : Form
    {
        private DrawingImageProvider _provider1;


        private MediaConnector connector;
        private WebCamera webCamera;
        private IIPCamera ipCamera;
        public VistaCamaras()
        {
            InitializeComponent();
            connector = new MediaConnector();
            _provider1 = new DrawingImageProvider();
        }


        private async Task SetVideoViewer()
        {
            videoViewerWFCamara1.SetImageProvider(_provider1);
            await ConnectWebCamera();
            
        }
        private async Task ConnectWebCamera()
        {
            await Task.Run(() =>
            {
                webCamera = WebCamera.GetDefaultDevice();
                if (webCamera == null) return;
                connector.Connect(webCamera, _provider1);
                webCamera.Start();
                videoViewerWFCamara1.Start();
            });

        }
        /*private async Task ConnectIpCamera()
        {
            await Task.Run(() =>
            {

                webCamera = WebCamera.GetDefaultDevice();
                if (webCamera == null) return;
                connector.Connect(webCamera, _provider2);
                webCamera.Start();
                videoViewerWFCamara2.Start();
                ipCamera = IPCameraFactory.GetCamera("192.168.1.71:1080", "diego", "jmdalj41");
                if (ipCamera == null) return;
                connector.Connect(ipCamera.VideoChannel, _provider2);
                ipCamera.Start();
                videoViewerWFCamara2.Start();
            });
        }*/

        private async void VistaCamaras_Load(object sender, EventArgs e)
        {
            await SetVideoViewer();
        }
    }
}
