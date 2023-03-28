using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Sugerencias_CL
{
    internal class CDetalle_sugerencia:CSugerirComida
    {
        private int id_detalle_sugerencia;
        private int id_sugerencia;
        private string ingrediente;
        private string unidad_medida;
        private decimal cantidad_medida;
        private string observacion;

        public int Id_detalle_sugerencia { get => id_detalle_sugerencia; set => id_detalle_sugerencia = value; }
        public int Id_sugerencia1 { get => id_sugerencia; set => id_sugerencia = value; }
        public string Ingrediente { get => ingrediente; set => ingrediente = value; }
        public string Unidad_medida { get => unidad_medida; set => unidad_medida = value; }
        public decimal Cantidad_medida { get => cantidad_medida; set => cantidad_medida = value; }
        public string Observacion { get => observacion; set => observacion = value; }

        private void registrar_detelle_sugerencia() { }
        private void eliminar_detalle() { }
        public void listar_detalle() { }
    }
}
