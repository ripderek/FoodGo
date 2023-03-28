using Gmap.net.Enums;
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
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
        {
            InitializeComponent();
            csListarOrdnes Ordnes = new csListarOrdnes();
            dataGridView1.DataSource = Ordnes.listarpro();
        }

        private int posicion;
        private int fila;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //abrir una venta con el detalle de la orden es decir los productos y que aparesca un boton para cambiar 
            //El estado de la orden para que pase a Listo para enviar y que aparesca en los envios pendientes para los
            //repartidores 
            posicion = dataGridView1.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            int id_orden = int.Parse(dataGridView1[0, posicion].Value.ToString());
            int id_carrito = int.Parse(dataGridView1[3, posicion].Value.ToString());

            //txtBusqueda.Text = (dtgvBusqueda[0, posicion].Value.ToString());
            Ver_DetalleOrden detalle = new Ver_DetalleOrden(id_carrito,id_orden);
            detalle.ShowDialog();
            //Refrescars
            csListarOrdnes Ordnes = new csListarOrdnes();
            dataGridView1.DataSource = Ordnes.listarpro();
        }


    }
}

