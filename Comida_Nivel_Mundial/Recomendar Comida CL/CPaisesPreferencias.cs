using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Recomendar_Comida_CL
{
    internal class CPaisesPreferencias
    {
        private int id_preferencia;
        private string pais;
        private int id_cliente;

        public int Id_preferencia { get => id_preferencia; set => id_preferencia = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }

        private void anadir_pais() { }
        private void remover_pais() { }
        private void listar_pais() { }
    }
}
