using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Entidades;
using System.Globalization;


namespace Datos
{
    public class ConexionMYSQL
    {

        static string db_punto= "server= localhost; database= punto_de_venta; port= 3306; user= root; password= Jp0w@3sujq245.;";

        MySqlConnection conexion = new MySqlConnection(db_punto);

        public int consultaLogin (string Usuario, string Contrasena)
        {
            int count;
            conexion.Open();
            string query = "Select count(*) from Persona where usuario= @usuario and contrasena= @contrasena";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            //parametros

            cmd.Parameters.AddWithValue("@usuario", Usuario);
            cmd.Parameters.AddWithValue("@contrasena", Contrasena);

            //nos devuelve un valor el cual se convierte en int 
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conexion.Close();

            return count;   


        }


        public int AgregarUsuario(string nom, string apel, string ced, string tel, string user, string pass)
        {
            int flag = 0;
            conexion.Open();
            string query = "insert into Persona (nombre, apellidos, cedula, telefono, usuario, contrasena) values (@nombre, @apellidos, @cedula, @telefono, @usuario, @contrasena)";
            MySqlCommand cmd = new MySqlCommand(query, conexion);

            string[] parametros = { "@nombre", "@apellidos", "@cedula", "@telefono", "@usuario","@contrasena"};
            object[] valores = {nom, apel, ced, tel, user, pass };

            for (int i = 0; i < parametros.Length; i++)
            {
                cmd.Parameters.AddWithValue(parametros[i], valores[i]);
            }

            flag = cmd.ExecuteNonQuery();
            conexion.Close();
            return flag;

            
        }

        public int ModificarUsuario(string nom, string apel, string tel,  string pass, string ced)
        {
            int flag = 0;
            conexion.Open();
            string query = "update Persona set nombre= @nombre, apellidos= @apellidos, telefono= @telefono, contrasena= @contrasena where cedula= @cedula";
            MySqlCommand cmd = new MySqlCommand(query, conexion);

            //parametros de seguridad
            string[] parametros = { "@nombre", "@apellidos", "@telefono", "@contrasena", "@cedula"};
            object[] valores = { nom, apel, tel, pass, ced};

            for (int i = 0; i < parametros.Length; i++)
            {
                cmd.Parameters.AddWithValue(parametros[i], valores[i]);
            }

            flag = cmd.ExecuteNonQuery();
            conexion.Close();

            return flag;

        }

        public int EliminarUsuario(string ced, string user)
        {
            int flag = 0;
            conexion.Open();

            string query = "delete from Persona where cedula= @cedula and usuario= @usuario";
            MySqlCommand cmd = new MySqlCommand(query, conexion);

            string[] parametros = { "@cedula", "@usuario" };
            object[] valores = { ced, user};

            for (int i = 0; i < parametros.Length; i++)
            {
                cmd.Parameters.AddWithValue(parametros[i], valores[i]);
            }

            flag = cmd.ExecuteNonQuery();

            return flag;

        }

        public DataTable ConsultarUsuarios()
        {
            string query = "Select * from Persona";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public string ConsultaFactura ()
        {
            conexion.Open();
            string resultado = "Null";
            string query = "Select (SELECT DISTINCT NumFactura FROM Facturacion ORDER BY NumFactura DESC LIMIT 1) + 1 as NumFactura;";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado = reg["NumFactura"].ToString();
            }
           

            conexion.Close();
            return resultado;

        }

        public Tuple<string, string> ConsultaLista(string codigo)
        {
            conexion.Open();
            string resultado1 = "Null";
            string resultado2 = "Null";
            string query = "select * from Inventario where Codigo= @codigo";            
            MySqlCommand cmd = new MySqlCommand(query, conexion);

            //parametros del query
            cmd.Parameters.AddWithValue("@codigo", codigo);


            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado1 = reg["Producto"].ToString();
                resultado2 = reg["Precio"].ToString();

            }
            conexion.Close();
                return Tuple.Create(resultado1, resultado2);

        }

        public Tuple<string, double> ConsultaCliente(string codigo_cli)
        {
            conexion.Open();
            string resultado1 = "Null";
            double resultado2 = 0;
            string query = "select concat(nombre_cliente, ' ', apellido_cliente) as Nombre,  descuento_cliente from Cliente where codigo_cliente = @codigo_cli;";
            MySqlCommand cmd = new MySqlCommand(query, conexion);

            //parametros query

            cmd.Parameters.AddWithValue("@codigo_cli", codigo_cli);

            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado1 = reg["Nombre"].ToString();
                resultado2 = double.Parse(reg["descuento_cliente"].ToString());

            }
            conexion.Close();
            return Tuple.Create(resultado1, resultado2);

        }

        

        public void InsertarFactura(List<Factura> F)
        {
            try
            {
                conexion.Open();

                foreach (Factura fact in F)
                {
                    string query = @"INSERT INTO Facturacion (codigo_factura, producto, precio_por_unidad, cantidad, descuento, precio_total, nombre_cliente, descuento_cliente, monto_total, NumFactura) VALUES (@codigoFact, @producto, @precioPorUnidad, @cantidad, @descuento, @precioTotal, @nombreCliente, @descuentoCliente, @montoTotal, @numFactura);";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    // Convertir y manejar el descuento
                    double descuento;
                    if (!double.TryParse(fact.Descuento.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out descuento))
                    {
                        descuento = 0.00; // Valor por defecto si la conversión falla
                    }

                    // Verificar que el nombre del cliente no sea nulo o vacío
                    if (string.IsNullOrEmpty(fact.Cliente))
                    {
                        fact.Cliente = "Cliente no especificado"; // Valor por defecto
                    }

                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@codigoFact", fact.Codigo);
                    cmd.Parameters.AddWithValue("@producto", fact.Producto);
                    cmd.Parameters.AddWithValue("@precioPorUnidad", Convert.ToDouble(fact.PrecioXProducto));
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(fact.Cantidad));
                    cmd.Parameters.AddWithValue("@descuento", descuento);
                    cmd.Parameters.AddWithValue("@precioTotal", Convert.ToDouble(fact.PrecioTotal));
                    cmd.Parameters.AddWithValue("@nombreCliente", fact.Cliente);
                    cmd.Parameters.AddWithValue("@descuentoCliente", Convert.ToDouble(fact.ClienteDesc));
                    cmd.Parameters.AddWithValue("@montoTotal", Convert.ToDouble(fact.Total));
                    cmd.Parameters.AddWithValue("@numFactura", Convert.ToInt32(fact.NFactura));

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();

                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
