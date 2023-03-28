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
    internal class csListarDetalleOrden
    {
        CsConexion conexion = new CsConexion();

        public int id_carro;
        private string comida;
        private string descripcion;
        private decimal precio;

        public string Comida { get => comida; set => comida = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public List<csListarDetalleOrden> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_Ver_Detalle_Orden", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.abrirCerrarConexion();
            cmd.Parameters.AddWithValue("@Id_Carro", id_carro);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csListarDetalleOrden> lstEspe = new List<csListarDetalleOrden>();
            csListarDetalleOrden objeraza;
            while (dr.Read())
            {
                objeraza = new csListarDetalleOrden();
                //objeraza.Busqueda = dr.GetString(0);
                objeraza.Comida = dr.GetString(0);
                objeraza.Descripcion = dr.GetString(1);
                objeraza.Precio = decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                lstEspe.Add(objeraza);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstEspe;
        }
    }
}
