using Comida_Nivel_Mundial.Entregas_CL;
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
    public partial class frmMapaRepartidor : Form
    {
        private int id_empleado_repartidor;
        private int id_envio;
        frmInicioRepartidor inicioRepartidor;
        public frmMapaRepartidor(int id_emp, frmInicioRepartidor form)
        {
            InitializeComponent();
            id_empleado_repartidor = id_emp;
           // MessageBox.Show(id_empleado_repartidor.ToString());
            if (form != null)
            {
                InicioRepartidor = form;
            }
            CEnvios map_envio = new CEnvios();
            MessageBox.Show(map_envio.ver_datos_envio(id_empleado_repartidor).ToString());
            id_envio = map_envio.Envios_id;
            txtEntregar.Text = "Entregar a: " +map_envio.Nombres;
            txtLlamar.Text = "Llamar a: " + map_envio.N_celular;
            //PARA EL GMAP
            GMarkerGoogle marker;
            GMapOverlay markoverlay;
            //INICIAR EL GMAP CON LA UBICACION
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new GMap.NET.PointLatLng(double.Parse(map_envio.Ubi1entrega), double.Parse(map_envio.Ubi2entrega));
            gMapControl1.MaxZoom = 24;
            gMapControl1.MinZoom = 0;
            gMapControl1.Zoom = 13;
            gMapControl1.AutoScroll = true;
            //marcador
            markoverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(double.Parse(map_envio.Ubi1entrega), double.Parse(map_envio.Ubi2entrega)), GMarkerGoogleType.pink_dot);
            markoverlay.Markers.Add(marker);
            //agregarlo al mapa
            gMapControl1.Overlays.Add(markoverlay);


            //marcador
            markoverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new GMap.NET.PointLatLng(double.Parse(map_envio.Entregabui1), double.Parse(map_envio.Entregabui2)), GMarkerGoogleType.green);
            markoverlay.Markers.Add(marker);
            //agregarlo al mapa
            gMapControl1.Overlays.Add(markoverlay);
        }
       

        public frmInicioRepartidor InicioRepartidor { get => inicioRepartidor; set => inicioRepartidor = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            //MOSTRAR EN UN MENSAJE LOS DATOS XD 


            //map_envio.ver_datos_envio(id_empleado_repartidor);
            //  MessageBox.Show(map_envio.Nombres + map_envio.N_celular + map_envio.Ubi1entrega + map_envio.Ubi2entrega + map_envio.Entregabui1);
            //button1.Text = map_envio.Nombres;
            MessageBox.Show("ID DEL ENVIO A CAMBIAR"+ id_envio);

            MessageBox.Show("La orden finalizo");
            CEnvios map_envio = new CEnvios();
            map_envio.cambiar_estado(id_envio);
            InicioRepartidor.Finalizar();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
