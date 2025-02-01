using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private string codigo = "";
        private string producto = "";
        private string precioXProducto = "";
        private string cantidad = "";
        private string descuento = "";
        private string precioTotal = "";
        private string subTotal = "";
        private string cliente = "";
        private string clienteDesc = "";
        private string total = "";
        private string nFactura = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PrecioXProducto { get => precioXProducto; set => precioXProducto = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string ClienteDesc { get => clienteDesc; set => clienteDesc = value; }
        public string Total { get => total; set => total = value; }
        public string NFactura { get => nFactura; set => nFactura = value; }
    }
}
