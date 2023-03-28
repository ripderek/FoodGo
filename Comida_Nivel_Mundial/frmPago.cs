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
    public partial class frmPago : Form
    {
        frmInicioCliente iniciocliente;
        public frmPago()
        {
            InitializeComponent();
        }
        public frmPago(frmInicioCliente form)
        {
            InitializeComponent();
            if (form != null)
            {
                Iniciocliente = form;
            }
        }

        public frmInicioCliente Iniciocliente { get => iniciocliente; set => iniciocliente = value; }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; //DESHABILITAR
            //Iniciocliente.VER_Mapa();

        }
    }
}
