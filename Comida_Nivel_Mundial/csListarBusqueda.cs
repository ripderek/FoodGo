using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Comida_Nivel_Mundial
{
    internal class csListarBusqueda
    {
        CsConexion conexion = new CsConexion();
        private string busqueda;
        public string PalabraClave;
        public string numerosResultados="0";

        public string Busqueda { get => busqueda; set => busqueda = value; }
        public List<csListarBusqueda> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_Listar_BUSQUEDA_COMIDA", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.abrirCerrarConexion();
            cmd.Parameters.AddWithValue("@palabra", PalabraClave);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<csListarBusqueda> lstEspe = new List<csListarBusqueda>();
            csListarBusqueda objeraza;
            while (dr.Read())
            {
                objeraza = new csListarBusqueda();
                objeraza.Busqueda = dr.GetString(0);
                numerosResultados = dr.GetInt64(1).ToString();
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
