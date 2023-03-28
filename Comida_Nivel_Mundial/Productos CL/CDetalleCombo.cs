using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Productos_CL
{
    internal class CDetalleCombo:CCombosComidas
    {
        private int id_detalle_combo;
        private int id_combo;
        private int id_comida;
        private int cantidad_producto;

        public int Id_detalle_combo { get => id_detalle_combo; set => id_detalle_combo = value; }
        public int Id_combo1 { get => id_combo; set => id_combo = value; }
        public int Id_comida1 { get => id_comida; set => id_comida = value; }
        public int Cantidad_producto { get => cantidad_producto; set => cantidad_producto = value; }

        private void agregar_comida() { }
        private void ver_detalle() { }
    }
}
