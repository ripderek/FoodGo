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
    internal class csListarOrdnes
    {
        CsConexion conexion = new CsConexion();
        private int id_orden;
        private string estado;
        private int id_factura;
        private int id_carrito_compras;

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_carrito_compras { get => id_carrito_compras; set => id_carrito_compras = value; }

        public List<csListarOrdnes> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_Ver_Ordenes", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.abrirCerrarConexion();
            //cmd.Parameters.AddWithValue("@id_Persona", id_persona);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csListarOrdnes> lstEspe = new List<csListarOrdnes>();
            csListarOrdnes objeraza;
            while (dr.Read())
            {
                objeraza = new csListarOrdnes();
                //objeraza.Busqueda = dr.GetString(0);
                objeraza.Id_orden = dr.GetInt32(0);
                objeraza.Estado = dr.GetString(1);
                objeraza.Id_factura = dr.GetInt32(2);
                objeraza.Id_carrito_compras = dr.GetInt32(3);
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
