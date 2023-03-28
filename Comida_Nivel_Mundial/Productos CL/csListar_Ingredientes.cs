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
    internal class csListar_Ingredientes
    {
        CsConexion conexion = new CsConexion();

        private int id_ingrediente;
        private string nombre_ingrediente;
        private string descripcion;

        public int Id_ingrediente { get => id_ingrediente; set => id_ingrediente = value; }
        public string Nombre_ingrediente { get => nombre_ingrediente; set => nombre_ingrediente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public List<csListar_Ingredientes> listarIngredientes()
        {


            //Para almacenar el resultado de la lectura de los datos
            SqlDataReader dr;

            SqlCommand cmd = new SqlCommand("SP_Listar_Ingredientes", conexion.con);
            //Tipo de sentencia a ejecutar
            cmd.CommandType = CommandType.StoredProcedure;
            //Abrir conexionç

            //conexion.abrirCerrarConexion();
            conexion.abrirCerrarConexion();


            dr = cmd.ExecuteReader();

            List<csListar_Ingredientes> lstClien = new List<csListar_Ingredientes>();
            csListar_Ingredientes objclien;
            while (dr.Read())
            {
                objclien = new csListar_Ingredientes();
                objclien.Id_ingrediente = dr.GetInt32(0);
                objclien.Nombre_ingrediente = dr.GetString(1);
                objclien.Descripcion = dr.GetString(2);
                lstClien.Add(objclien);
            }
            // Cierra Conexion
            conexion.abrirCerrarConexion();
            //conexion.abrirCerrarConexion();
            dr.Close();
            return lstClien;
        }
    }
}
