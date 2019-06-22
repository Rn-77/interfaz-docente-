using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMostrar : Form
    {
        public frmMostrar()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdUsurioAcDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.bdUsurioAcDataSet.Usuario);

        }
    }
}
