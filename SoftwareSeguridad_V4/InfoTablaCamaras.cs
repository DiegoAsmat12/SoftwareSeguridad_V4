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
    public partial class InfoTablaCamaras : Form
    {
        DataTable table;
        public InfoTablaCamaras()
        {
            InitializeComponent();
        }

        private async void InfoTablaCamaras_Load(object sender, EventArgs e)
        {
            await LlenarTablaCamaras();
        }
        private async Task LlenarTablaCamaras()
        {
            table = new DataTable();
            await Task.Run(() =>
            {
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("Direccion", typeof(string));
                table.Columns.Add("Latitud", typeof(double));
                table.Columns.Add("Longitud", typeof(double));
                table.Columns.Add("Estado", typeof(string));

                
            });
            dataGridViewTablaCamaras.DataSource = table;

        }
    }
}
