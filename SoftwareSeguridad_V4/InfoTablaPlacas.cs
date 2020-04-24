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
        public int height;
        public InfoTablaPlacas()
        {
            InitializeComponent();
        }

        private void InfoTablaPlacas_Load(object sender, EventArgs e)
        {
            splitContainerInfoTablaPlacas.SplitterDistance=this.Height-405;
            splitContainerInfoTablaPlacas.Panel2Collapsed = true;
            height = splitContainerInfoTablaPlacas.SplitterDistance;
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

        private void expandirButtonDenuncia_Click(object sender, EventArgs e)
        {
            if (splitContainerInfoTablaPlacas.Panel2Collapsed)
            {
                expandirButtonDenuncia.Image = Properties.Resources.IconoContraerVertical;
                splitContainerInfoTablaPlacas.Panel2Collapsed = false;
            }
            else
            {
                expandirButtonDenuncia.Image = Properties.Resources.IconoExpandirVertical;
                splitContainerInfoTablaPlacas.Panel2Collapsed = true;
            }
            if (splitContainerInfoTablaPlacas.SplitterDistance <= 200)
            {
                splitContainerInfoTablaPlacas.SplitterDistance =0;
            }
            if(splitContainerInfoTablaPlacas.SplitterDistance > 200)
            {
                splitContainerInfoTablaPlacas.SplitterDistance = height;
            }


        }
    }
}
