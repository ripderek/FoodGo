using Comida_Nivel_Mundial.Carro_de_compras_CL;
using Comida_Nivel_Mundial.Productos_CL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
///LOS CONTROLADORES PARA EL GMAP 
using Gmap.net;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using Comida_Nivel_Mundial.Ventas_Cl;

namespace Comida_Nivel_Mundial
{
    public partial class frmCarrito : Form
    {
        private int id_persona;
        frmInicioCliente iniciocliente;
        public frmInicioCliente Iniciocliente { get => iniciocliente; set => iniciocliente = value; }

        //PARA EL GMAP
        GMarkerGoogle marker;
        GMapOverlay markoverlay;

        //-0.16124496630925136, -78.48405703368441 //Quito
        //-1.0069801903477051, -79.46032247138983
        //-1.0068280435692383, -79.460728258781   //Quevedo 
        double latinicial = -1.0068280435692383;
        double lnginicial = -79.46032247138983;

        public frmCarrito(int id_per, frmInicioCliente form)
        {
            InitializeComponent();
            id_persona = id_per;
            if (form != null)
            {
                Iniciocliente = form;
            }
            Listar_Carrito carrito = new Listar_Carrito();
            carrito.id_persona = id_per;
            dataGridView1.DataSource = carrito.listarpro();
            decimal precio = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                precio = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())+precio; 
            }
            txtprecio.Text ="$"+ (precio+carrito.precio_envio).ToString("N2");
            textBox1.Text = "Envio: $" + carrito.precio_envio;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Comida";
            dataGridView1.Columns[2].HeaderText = "Precio";
            dataGridView1.Columns[3].HeaderText = "Descripcion";


            //INICIAR EL GMAP CON LA UBICACION
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(latinicial, lnginicial);
            gMapControl1.MaxZoom = 24;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom =16;
            gMapControl1.AutoScroll = true;
            //marcador
            markoverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(latinicial, lnginicial), GMarkerGoogleType.pink_dot);
            markoverlay.Markers.Add(marker);
            //agregarlo al mapa
            gMapControl1.Overlays.Add(markoverlay);
        }

        private void uI_ShadowPanel2_Click(object sender, EventArgs e)
        {        
            DialogResult resultado = new DialogResult();
            Form mensaje = new frmPago(this.Iniciocliente);
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                //AQUI ANADIR A LA FACTURA ESTE CARRO Y CAMBIAR TODOS LOS PRODUCTOS A PAGADO
               
                    //  precio = decimal.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + precio;
                    CFactura objFactura = new CFactura(id_persona, int.Parse(dataGridView1.Rows[0].Cells[4].Value.ToString()),latinicial.ToString(),lnginicial.ToString());
                    Iniciocliente.VER_Mapa();

                //dataGridView1.Rows.Clear();
            }
        }
    }
}
