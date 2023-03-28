using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
namespace Comida_Nivel_Mundial.Productos_CL
{
    internal class Listar_Carrito
    {
        CsConexion conexion = new CsConexion();
        private int variante_id;
        private string nombre_varainte;
        private decimal precio_variante;
        private string descripicon;
        public int id_persona;
        public decimal precio_envio;
        private int id_carrito;
        public int Variante_id { get => variante_id; set => variante_id = value; }
        public string Nombre_varainte { get => nombre_varainte; set => nombre_varainte = value; }
        public decimal Precio_variante { get => precio_variante; set => precio_variante = value; }
        public string Descripicon { get => descripicon; set => descripicon = value; }
        public int Id_carrito { get => id_carrito; set => id_carrito = value; }

        public List<Listar_Carrito> listarpro()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_Ver_Carrito", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;

            //conexion.abrirCerrarConexion();
            conexion.abrirCerrarConexion();
            cmd.Parameters.AddWithValue("@id_Persona", id_persona);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();

            List<Listar_Carrito> lstEspe = new List<Listar_Carrito>();
            Listar_Carrito objeraza;
            while (dr.Read())
            {
                objeraza = new Listar_Carrito();
                //objeraza.Busqueda = dr.GetString(0);
                objeraza.Variante_id = dr.GetInt32(0);
                objeraza.Nombre_varainte = dr.GetString(1);
                objeraza.Precio_variante = decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                objeraza.Descripicon = dr.GetString(3);
                precio_envio = decimal.Parse(dr.GetDecimal(4).ToString("N2"));
                objeraza.Id_carrito = dr.GetInt32(5);

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
