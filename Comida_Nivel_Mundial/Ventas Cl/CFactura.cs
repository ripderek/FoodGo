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

namespace Comida_Nivel_Mundial.Ventas_Cl
{
    internal class CFactura
    {
        private int id_persona;
        private int id_carro;
        private string latitud;
        private string longitud;
        CsConexion conexion = new CsConexion();

        public int Id_persona { get => id_persona; set => id_persona = value; }
        public int Id_carro { get => id_carro; set => id_carro = value; }
        public string Latitud { get => latitud; set => latitud = value; }
        public string Longitud { get => longitud; set => longitud = value; }

        //Constructor para crear la factura 
        public CFactura(int id_p, int id_c, string lat, string longs) 
        {
            Id_persona = id_p; Id_carro = id_c; Latitud = lat; Longitud = longs;
            CrearFactura();
        }
        private void CrearFactura()
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Crear_Factura", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_Persona", Id_persona);
                cmd.Parameters.AddWithValue("@id_carrito", Id_carro);
                cmd.Parameters.AddWithValue("@latitud", Latitud);
                cmd.Parameters.AddWithValue("@longitud", Longitud);
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
