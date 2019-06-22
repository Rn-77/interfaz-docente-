using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class ventana_login : Form
    {
        public ventana_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_aceptar_Click(object sender, EventArgs e)
        {
            //SqlConnection cn = new SqlConnection ("server=.\SQLEXPRESS")
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar frmincio = new frmMostrar();
            frmincio.Show();
        }
    }
}
