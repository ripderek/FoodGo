using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Usuarios_Aplicacion
{
    internal class CCliente:CUsuario
    {
        private int id_preferencias;
        private int id_cliente;
        private byte estad_cliente;

        public int Id_preferencias { get => id_preferencias; set => id_preferencias = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public byte Estad_cliente { get => estad_cliente; set => estad_cliente = value; }

        private void registrar_cliente() { }
        private void modificar_cliente() { }
        private void cambiar_estado() { }
    }
}
