using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Productos_CL
{
    internal class CVariantesComida:CComida
    {
        private int id_variante;
        private string nombre_variante;
        private double precio_va;
        private Bitmap foto;
        private string ingredientes;
        private string descripcion;
        private byte estado;

        public int Id_variante { get => id_variante; set => id_variante = value; }
        public string Nombre_variante { get => nombre_variante; set => nombre_variante = value; }
        public double Precio_va { get => precio_va; set => precio_va = value; }
        public Bitmap Foto { get => foto; set => foto = value; }
        public string Ingredientes { get => ingredientes; set => ingredientes = value; }
        public string Descripcion1 { get => descripcion; set => descripcion = value; }
        public byte Estado1 { get => estado; set => estado = value; }

        private void registrar_variante() { }
        private void modificar_variante() { }
        private void eliminar_variante() { }
        private void cambiar_estado() { }
        private void ver_datos() { }
    }
}
