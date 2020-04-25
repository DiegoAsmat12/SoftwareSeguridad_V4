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
    public partial class InfoTablaListaNegra : Form
    {
        DataTable tableAlertas;
        public int cantidadDeDatos;
        public InfoTablaListaNegra()
        {
            InitializeComponent();
        }

        private void InfoTablaListaNegra_Load(object sender, EventArgs e)
        {
            LlenarTablaPlacasListaNegra();
        }
        private void LlenarTablaPlacasListaNegra()
        {
            tableAlertas = new DataTable();
            bool correcto = Int32.TryParse(maskedTextBoxCantidadDeDatos.Text, out cantidadDeDatos);
            if (correcto)
            {
                tableAlertas.Columns.Add("Placa", typeof(string));
                tableAlertas.Columns.Add("Ubicación", typeof(string));
                tableAlertas.Columns.Add("Hora", typeof(string));
                object[] o = { "", "", "" };
                for (int i = 0; i < cantidadDeDatos; i++)
                {
                    tableAlertas.Rows.Add(o);
                }

                dataGridViewTablaPlacaListaNegra.DataSource = tableAlertas;
            }
        }
    }
}
