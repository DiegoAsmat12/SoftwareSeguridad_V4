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
    public partial class InfoTablaSerenazgos : Form
    {
        DataTable tableSeguridad;
        public InfoTablaSerenazgos()
        {
            InitializeComponent();
        }

        private async void InfoTablaSerenazgos_Load(object sender, EventArgs e)
        {
            await LlenarTablaSeguridad();
        }
        private async Task LlenarTablaSeguridad()
        {
            tableSeguridad = new DataTable();
            await Task.Run(() =>
            {
                tableSeguridad.Columns.Add("Ubicación", typeof(string));
                tableSeguridad.Columns.Add("Estado", typeof(string));
                tableSeguridad.Columns.Add("Activo", typeof(string));

            });
            dataGridViewTablaPlacaListaNegra.DataSource = tableSeguridad;
            
        }
    }
}
