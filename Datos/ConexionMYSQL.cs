using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
            string query = "Select count(*) from Persona where usuario= '"+ Usuario +"' and contrasena= '"+ Contrasena +"'";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
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
            string query = "";
            MySqlCommand cmd = new MySqlCommand(query, conexion);

            return "";

        }

    }
}
