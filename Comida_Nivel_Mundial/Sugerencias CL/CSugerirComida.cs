using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Comida_Nivel_Mundial.Sugerencias_CL
{
    internal class CSugerirComida
    {
        private int id_sugerencia;
        private int tipo_sugerencia;
        private string nombre;
        private string descripcion;
        private string pais_origen;
        private byte estado_sugerencia;

        public int Id_sugerencia { get => id_sugerencia; set => id_sugerencia = value; }
        public int Tipo_sugerencia { get => tipo_sugerencia; set => tipo_sugerencia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Pais_origen { get => pais_origen; set => pais_origen = value; }
        public byte Estado_sugerencia { get => estado_sugerencia; set => estado_sugerencia = value; }

        private void Registrar_Sugerencia() { 
        }
        private void Listar_Sugerencia() { }
        private void Aceptar_Sugerencia() { }
        private void Eliminar_Suegerencia() { }
    }
}
