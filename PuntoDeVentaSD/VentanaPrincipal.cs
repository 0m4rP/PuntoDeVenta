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
using Negocios;
using Entidades;

namespace PuntoDeVentaSD
{
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;

        ConexionMYSQLN cn = new ConexionMYSQLN();

        private double subtotal = 0;
        private double total = 0;
        private double desc = 0;
        private string cliente = "";
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

            txt_Factura.Text = cn.ConsultaFactura();

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
            var resultado = cn.ConsultaLista(txt_CodigoProducto.Text);
            var operacion = Int32.Parse(txt_Cantidad.Text) * double.Parse(resultado.Item2);

            DataRow row = dt.NewRow();

            row["Codigo"] = txt_CodigoProducto.Text;
            row["Producto"] = resultado.Item1;
            row["Precio por unidad"] = resultado.Item2;
            row["Cantidad"] = txt_Cantidad.Text;
            row["Descuento"] = txt_Descuento.Text;
            row["Precio total"] = operacion;

            dt.Rows.Add(row);

            subtotal += operacion;
            double impuesto = double.Parse(txt_arc_Impuesto.Text) / 100;

            total = subtotal + (subtotal * impuesto);

            if (desc == 0)
            {
                total = subtotal + (subtotal * impuesto);
            }
            else
            {
                total = subtotal + (subtotal * impuesto);
                total = total - (total*desc);
            }


            lbl_Subtotal.Text = subtotal.ToString();
            lbl_Total.Text = total.ToString();

        }

        private void txt_arc_Impuesto_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            var resultado2 = cn.ConsultaCliente(txt_ClienteBuscar.Text);

            txt_Cliente.Text = resultado2.Item1;
            txt_ClienteDesc.Text = "Desc:" + resultado2.Item2;


            desc = resultado2.Item2;

        }

        private void btn_Facturar_Click(object sender, EventArgs e)
        {

            Factura fact = new Factura();
            List<Factura> factos = new List<Factura>();

            foreach (DataRow row in dt.Rows)
            {
            
                fact.Codigo = row["Codigo"].ToString();
                fact.Producto = row["Producto"].ToString();
                fact.PrecioXProducto = row["Precio por unidad"].ToString();
                fact.Cantidad = row["Cantidad"].ToString();
                fact.Descuento = row["Descuento"].ToString();
                fact.PrecioTotal = row["Precio total"].ToString();
                fact.SubTotal = subtotal.ToString();
                fact.Cliente = cliente.ToString();
                fact.ClienteDesc = desc.ToString();
                fact.Total = total.ToString();
                fact.NFactura = txt_Factura.Text;

                factos.Add(fact);

            }

            MessageBox.Show(factos.Count().ToString());
        }
    }
}
