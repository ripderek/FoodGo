using Comida_Nivel_Mundial.Entregas_CL;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
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
    public partial class frmMapaCliente : Form
    {
        public frmMapaCliente(int idpers)
        {
            InitializeComponent();
            CEnvios map_envio = new CEnvios();
            map_envio.Datos_CLiente(idpers);
            txtEntregar.Text = "Entregar a: " + map_envio.Nombres;
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
    }
}
