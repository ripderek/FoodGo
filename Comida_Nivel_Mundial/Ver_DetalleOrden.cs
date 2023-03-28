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
    public partial class Ver_DetalleOrden : Form
    {
        private int carro;
        private int orden =0;
        public Ver_DetalleOrden(int id_carro, int id_orden)
        {
            InitializeComponent();
            carro = id_carro;
            orden = id_orden;
            csListarDetalleOrden detalle = new csListarDetalleOrden();
            detalle.id_carro = carro;
            dataGridView1.DataSource = detalle.listarpro();
        }

        private void uI_ShadowPanel1_Click(object sender, EventArgs e)
        {
            csOrdenes ordensss = new csOrdenes(orden);
            //AQUI ENVIAR EL ID DE LA ORDEN PARA CAMBIAR SU ESTADO = ENVIAR 
            MessageBox.Show("Los repartidores ahora pueden recoger esta orden");
        }
    }
}
