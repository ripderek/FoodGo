using Comida_Nivel_Mundial.Carro_de_compras_CL;
using Comida_Nivel_Mundial.Entregas_CL;
using Comida_Nivel_Mundial.Usuarios_Aplicacion;
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
    public partial class frmOrdenesEnvios : Form
    {
        frmInicioRepartidor inicio_repartidr;
        private int id_repartidor;
        public frmOrdenesEnvios(frmInicioRepartidor form, int idr)
        {
            InitializeComponent();
            csVerOrdenesEnviar ordenes = new csVerOrdenesEnviar();
            dataGridView1.DataSource = ordenes.listarpro();
            if (form != null)
            {
                Inicio_repartidr = form; 
            }
            id_repartidor = idr;
        }

        public frmInicioRepartidor Inicio_repartidr { get => inicio_repartidr; set => inicio_repartidr = value; }
        private int posicion;
        private int fila;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //AQUI abrir el mensaje para saber si desea hacer el pedido o no y crear el registo en la tabla jalando el id
            // DialogResult resultado = new DialogResult();
            //Form mensaje = new MessageBox_Si_NO(this.Iniciocliente);
            //resultado = mensaje.ShowDialog();
            //if (resultado == DialogResult.OK) //ELIMINAR
            posicion = dataGridView1.CurrentRow.Index;
            fila = e.RowIndex;
            int columna = e.ColumnIndex;
            int id_orden = int.Parse(dataGridView1[0, posicion].Value.ToString());
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageRepartidor(this.Inicio_repartidr);
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //Inicio_repartidr.Ver_Boton_Mapa(true);
                //Inicio_repartidr.Ver_Boton_Pedidos(false);
                string lat = "-1.0196296484464213";  //UBICACION
                string lng = "-79.45649945347459";    //Ubicacion 
                //-1.0196296484464213, -79.45649945347459
                CEnvios obenvios = new CEnvios(id_orden, id_repartidor,lat,lng);
                //MessageBox.Show(); 
                Console.WriteLine(id_orden.ToString() + id_repartidor+ lat+ lng);
                Inicio_repartidr.AbrirMapaRe();

            }
        }
    }
}
