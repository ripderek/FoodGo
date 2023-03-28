using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Recomendar_Comida_CL
{
    internal class CCategorias_Preferencia
    {
        private int id_Categorias_preferidas;
        private int id_categoria;
        private int id_cliente;

        public int Id_Categorias_preferidas { get => id_Categorias_preferidas; set => id_Categorias_preferidas = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }

        private void anadir_categorias() { }
        private void remover_categorias() { }
        private void listar_categorias_preferidas() { }
    }
}
