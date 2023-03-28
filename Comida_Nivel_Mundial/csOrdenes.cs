using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Comida_Nivel_Mundial.Productos_CL;

namespace Comida_Nivel_Mundial
{
    internal class csOrdenes
    {
        CsConexion conexion = new CsConexion();
        private int id_orden;

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public csOrdenes( int ord) 
        {
            Id_orden = ord;
            CambiarEstadoOrden();
        }
        private void CambiarEstadoOrden() 
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Cambiar_Estado_Orden", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Id_orden", Id_orden);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception en)
            {
                MessageBox.Show("Error:  " + en.Message);
            }
        }
    }
}
