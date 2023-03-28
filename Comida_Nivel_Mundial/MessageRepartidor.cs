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
    public partial class MessageRepartidor : Form
    {
        frmInicioRepartidor repartidro;
        public MessageRepartidor(frmInicioRepartidor form)
        {
            InitializeComponent();
            if (form != null)
            {
                repartidro = form;
            }
        }

        public frmInicioRepartidor Repartidro { get => repartidro; set => repartidro = value; }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; //DESHABILITAR
            //aqui enviar el metodo por si acaso xd 
           // Repartidro.Ver_Boton_Mapa(true);
        }
    }
}
