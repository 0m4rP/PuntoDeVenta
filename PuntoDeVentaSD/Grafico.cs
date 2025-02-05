using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using System.Windows.Forms.DataVisualization.Charting;

namespace PuntoDeVentaSD
{
    public partial class Grafico : Form
    {

        ConexionMYSQLN cm = new ConexionMYSQLN();

        public Grafico()
        {
            InitializeComponent();
        }

        private void btn_gra_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_gra_Cargar_Click(object sender, EventArgs e)
        {

            DataTable DT = cm.GraficoData();
            chart1.Titles.Add("Productos vendidos");

            foreach (DataRow row in DT.Rows)
            {
                Series series = chart1.Series.Add(row["Producto"].ToString());
                series.Points.Add(Convert.ToInt32(row["Cantidad"].ToString()));
                //muestra la cantidad encima de las barras
                series.Label = row["Cantidad"].ToString();
            }

        }
    }
}
