using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Productos_CL
{
    internal class CCombosComidas:CComida
    {
        private int id_combo;
        private string nombre_combo;
        private string fecha_creacion;
        private string fecha_caducidad;
        private byte estado;

        public int Id_combo { get => id_combo; set => id_combo = value; }
        public string Nombre_combo { get => nombre_combo; set => nombre_combo = value; }
        public string Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Fecha_caducidad { get => fecha_caducidad; set => fecha_caducidad = value; }
        public byte Estado1 { get => estado; set => estado = value; }

        private void crear_combo() { }
        private void eliminar_combo() { }
        private void cambiar_estado() { }
    }
}
