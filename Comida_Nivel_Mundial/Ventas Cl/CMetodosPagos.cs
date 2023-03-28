using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Ventas_Cl
{
    internal class CMetodosPagos
    {
        private int id_metodo_pago;
        private string metodo_pago;
        private string descripcion;
        private byte estado;

        public int Id_metodo_pago1 { get => id_metodo_pago; set => id_metodo_pago = value; }
        public string Metodo_pago { get => metodo_pago; set => metodo_pago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public byte Estado { get => estado; set => estado = value; }

        private void registrar_metodo_pago() { }
        private void cambibar_estado() { }
        private void eliminar_metodo() { }
    }
}
