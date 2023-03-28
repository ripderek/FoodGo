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
using System.Runtime.Remoting;

namespace Comida_Nivel_Mundial.Entregas_CL
{
    internal class csVerOrdenesEnviar
    {
        CsConexion conexion = new CsConexion();
        private int orden;
        private string latitud;
        private string longitud;

        public int Orden { get => orden; set => orden = value; }
        public string Latitud { get => latitud; set => latitud = value; }
        public string Longitud { get => longitud; set => longitud = value; }

        public List<csVerOrdenesEnviar> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_Ver_Ordenes_Repartidor", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.abrirCerrarConexion();
            //cmd.Parameters.AddWithValue("@Id_Carro", id_carro);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csVerOrdenesEnviar> lstEspe = new List<csVerOrdenesEnviar>();
            csVerOrdenesEnviar objeraza;
            while (dr.Read())
            {
                objeraza = new csVerOrdenesEnviar();
                //objeraza.Busqueda = dr.GetString(0);
                objeraza.Orden = dr.GetInt32(0);
                objeraza.Latitud = dr.GetString(1);
                objeraza.longitud = dr.GetString(2);
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
