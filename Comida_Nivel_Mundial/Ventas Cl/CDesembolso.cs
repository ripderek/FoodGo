using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Ventas_Cl
{
    internal class CDesembolso
    {
        private int id_reembolso;
        private int id_factura;
        private double porcentaje_devolucion;
        private double total_desembolso;
        private int id_envio;

        public int Id_reembolso { get => id_reembolso; set => id_reembolso = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public double Porcentaje_devolucion { get => porcentaje_devolucion; set => porcentaje_devolucion = value; }
        public double Total_desembolso { get => total_desembolso; set => total_desembolso = value; }
        public int Id_envio { get => id_envio; set => id_envio = value; }

        private void Calcular_desembolso() { }
    }
}
