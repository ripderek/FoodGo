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
    public partial class MessageBox_Si_NO : Form
    {
        frmInicioCliente iniciocliente;

        public frmInicioCliente Iniciocliente { get => iniciocliente; set => iniciocliente = value; }

        public MessageBox_Si_NO(frmInicioCliente form)
        {
            InitializeComponent();
            if (form != null)
            {
                Iniciocliente = form;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; //DESHABILITAR
            Iniciocliente.Numero_Carrito();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ///this.DialogResult = DialogResult.Ignore; //EDITAR
            this.Close();

        }
    }
}
