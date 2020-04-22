using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.Video;
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
    public partial class VistaSeguimiento : Form
    {
        private DrawingImageProvider _provider;

        private MediaConnector connector;
        private WebCamera webCamera;
        public VistaSeguimiento()
        {
            InitializeComponent();
            connector = new MediaConnector();
            _provider = new DrawingImageProvider();
            
        }

        private async void comboBoxCamara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCamara.SelectedIndex == 1)
            {
                await SetVideoViewer();
            }
            else if (comboBoxCamara.SelectedIndex == 2)
            {
                await SetVideoViewer();
            }
            else
            {
                if (webCamera != null)
                {
                    webCamera.Stop();
                    videoViewerWFRenderizador.Stop();
                }
            }
        }
        private async Task SetVideoViewer()
        {
            videoViewerWFRenderizador.SetImageProvider(_provider);
            await ConnectWebCamera();
        }
        private async Task ConnectWebCamera()
        {
            await Task.Run(() =>
            {
                webCamera = WebCamera.GetDefaultDevice();
                if (webCamera == null) return;
                connector.Connect(webCamera, _provider);
                webCamera.Start();
                videoViewerWFRenderizador.Start();
            });

        }
        

        private async void VistaSeguimiento_Load(object sender, EventArgs e)
        {
            comboBoxCamara.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCamara.SelectedIndex = 0;
            await SetVideoViewer();

        }
    }
}
