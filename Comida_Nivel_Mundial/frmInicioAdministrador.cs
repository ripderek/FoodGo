using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_Nivel_Mundial
{
    public partial class frmInicioAdministrador : Form
    {
        public frmInicioAdministrador()
        {
            InitializeComponent();
        }

        private void frmInicioAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Crear_Comida_Click(object sender, EventArgs e)
        {
            frmCrearComida crearcomida = new frmCrearComida();
            crearcomida.ShowDialog();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            frmOrdenes ordenes = new frmOrdenes();
            ordenes.ShowDialog();
        }
    }
}
