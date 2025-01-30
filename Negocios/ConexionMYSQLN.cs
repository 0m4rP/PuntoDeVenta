using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;

namespace Negocios
{
    public class ConexionMYSQLN
    {
        ConexionMYSQL cm = new ConexionMYSQL();

        public int ingreso(string user, string password)
        {

            return cm.consultaLogin(user, password);

        }

        public DataTable ConsultarUsersDT()
        {
            return cm.ConsultarUsuarios();
        }

        public int AgregarUsuario(string nom, string apel, string ced, string tel, string user, string pass)
        {

            return cm.AgregarUsuario(nom, apel, ced, tel, user, pass);

        }
        public int ModificarUsuario(string nom, string apel, string tel, string pass, string ced)
        {

            return cm.ModificarUsuario(nom, apel, tel, pass, ced);

        }

        public int ElminarUsuario(string ced, string user)
        {

            return cm.EliminarUsuario(ced, user);

        }

    }
}
