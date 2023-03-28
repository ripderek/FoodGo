using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Entregas_CL
{
    internal class CHistorial_Envio
    {
        private int id_historial;
        private int id_envio;
        private string ubicacion_entrega;
        private string fecha_historial;
        private string fecha_hora_para_recepcion;
        private string fecha_hora_entrega;
        private string descripcion;
        private int numero_cambio;

        public int Id_historial { get => id_historial; set => id_historial = value; }
        public int Id_envio { get => id_envio; set => id_envio = value; }
        public string Ubicacion_entrega { get => ubicacion_entrega; set => ubicacion_entrega = value; }
        public string Fecha_historial { get => fecha_historial; set => fecha_historial = value; }
        public string Fecha_hora_para_recepcion { get => fecha_hora_para_recepcion; set => fecha_hora_para_recepcion = value; }
        public string Fecha_hora_entrega { get => fecha_hora_entrega; set => fecha_hora_entrega = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Numero_cambio { get => numero_cambio; set => numero_cambio = value; }

        private void Agregar_historial() { }
        private void Calcular_distancia() { }
        private void Calcular_minutos_distancia() { }
        private bool desembolso() { return true; }
        private void ver_historial() { }
    }
}
