using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PuntoDeVentaSD
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;

        public VentanaPrincipal()
        {
            InitializeComponent();

            txt_Impuesto.Text = txt_arc_Impuesto.Text;
            txt_Descuento.Text = txt_arc_Descuento.Text;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio por unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio total");

            dgv_Principal.DataSource = dt;

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormUsers usuario = new FormUsers();
            this.Hide();
            usuario.ShowDialog();
            this.Show();

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            this.Hide();
            inv.ShowDialog();
            this.Show();
        }

        private void ImpVentaYDescChanged(object sender, EventArgs e)
        {
            txt_Impuesto.Text = txt_arc_Impuesto.Text;
            txt_Descuento.Text = txt_arc_Descuento.Text;

        }

        private void btn_AddProd_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();

            row["Codigo"] = txt_CodigoProducto.Text;
            row["Producto"] = "Producto x";
            row["Precio por unidad"] = "3500";
            row["Cantidad"] = txt_Cantidad.Text;
            row["Descuento"] = txt_Descuento.Text;
            row["Precio total"] = "5000";

            dt.Rows.Add(row);

        }
    }
}
