using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Recomendar_Comida_CL
{
    internal class CRecomendacionesPlatos:CPreferencias_Comida
    {
        private int id_recomendaciones;
        private int id_cliente;
        private int preferencias_comida;
        private int id_comida;

        public int Id_recomendaciones { get => id_recomendaciones; set => id_recomendaciones = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Preferencias_comida { get => preferencias_comida; set => preferencias_comida = value; }
        public int Id_comida1 { get => id_comida; set => id_comida = value; }

        private void Ver_Recomendaciones() { }
    }
}
