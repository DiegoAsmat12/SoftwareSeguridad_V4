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
    public partial class InfoTablaPlacas : Form
    {
        public DataTable table;
        public int cantidadDeDatos;
        public InfoTablaPlacas()
        {
            InitializeComponent();
        }

        private void InfoTablaPlacas_Load(object sender, EventArgs e)
        {
            LlenarTablaPlacas();
        }
        private void LlenarTablaPlacas()
        {
            
            bool correcto = Int32.TryParse(maskedTextBoxCantidadDeDatos.Text, out cantidadDeDatos);
            if (correcto)
            {
                table = new DataTable();

                table.Columns.Add("Numero", typeof(string));
                table.Columns.Add("Id", typeof(int));
                table.Columns.Add("Camara", typeof(string));
                table.Columns.Add("Codigo", typeof(string));
                table.Columns.Add("Direccion", typeof(string));
                table.Columns.Add("Hora", typeof(string));
                table.Columns.Add("Fecha", typeof(string));
                object[] o = { "", 0, "", "", "", "", "" };
                for (int i = 0; i < cantidadDeDatos; i++)
                {
                    table.Rows.Add(o);
                }


                dataGridViewTablaPlacas.DataSource = table;
            }
        }
    }
}
