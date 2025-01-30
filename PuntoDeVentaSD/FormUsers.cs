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
    public partial class FormUsers : Form
    {

        ConexionMYSQLN cm = new ConexionMYSQLN();

        public FormUsers()
        {
            InitializeComponent();
            dgv_Datos.DataSource = cm.ConsultarUsersDT();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            //nom,apel,ced,tel,user,pass
            cm.AgregarUsuario(txt_Nombre.Text, txt_Apellidos.Text, txt_Cedula.Text, txt_Telefono.Text, txt_Usuario.Text, txt_Contrasena.Text);
            dgv_Datos.DataSource = cm.ConsultarUsersDT();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            cm.ModificarUsuario(txt_Nombre.Text, txt_Apellidos.Text, txt_Telefono.Text, txt_Contrasena.Text, txt_Cedula.Text);
            dgv_Datos.DataSource = cm.ConsultarUsersDT();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cm.ElminarUsuario(txt_Cedula.Text, txt_Usuario.Text);
            dgv_Datos.DataSource = cm.ConsultarUsersDT();
        }
    }
}
