using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Productos_CL
{
    internal class CCategorias:CComida
    {
        private int id_categoria;
        private string nombre_categoria;
        private string descripcion;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }
        public string Descripcion1 { get => descripcion; set => descripcion = value; }

        private void agregar_categoria() { }
        private void modificar_categoria() { }
        private void cambiar_categoria() { }
        private void eliminar_categoria() { }
        private void ver_categoria() { }
    }
}
