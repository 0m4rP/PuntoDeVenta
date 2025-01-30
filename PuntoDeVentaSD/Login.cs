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


namespace PuntoDeVentaSD
{
    public partial class Login : Form
    {

        ConexionMYSQLN conn = new ConexionMYSQLN();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            if (conn.ingreso(txt_Usuario.Text, txt_Contrasena.Text) == 1)
            {
                MessageBox.Show("Conexión exitosa");

                this.Hide();

                VentanaPrincipal vp = new VentanaPrincipal();

                vp.Show();

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

        }
    }
}
