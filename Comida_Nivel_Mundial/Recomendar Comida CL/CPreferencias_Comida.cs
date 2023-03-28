using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Recomendar_Comida_CL
{
    internal class CPreferencias_Comida
    {
        private int id_preferencias;
        private int id_comida;

        public int Id_preferencias { get => id_preferencias; set => id_preferencias = value; }
        public int Id_comida { get => id_comida; set => id_comida = value; }
        public void eliminar_preferencias() { }
        public void agregar_preferencias() { }
    }
}
