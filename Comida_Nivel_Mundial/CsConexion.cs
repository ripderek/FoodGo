using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Comida_Nivel_Mundial.Usuarios_Aplicacion;
using System.Drawing;

namespace Comida_Nivel_Mundial
{
    internal class CsConexion
    {
        private string server;
        private string usuario;
        private string clave;
        private string base_de_datos;
        public SqlConnection con;
        public CsConexion()
        {
            server = ".";
            base_de_datos = "ComidaDomicilio";
            usuario = "raul";
            clave = "1405";

            con = new SqlConnection();
            con.ConnectionString = "Server=" + server + ";DataBase=" + base_de_datos
                + ";User id=" + usuario + ";Password=" + clave;
        }
        public bool abrirCerrarConexion()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }
            return true;
        }
    }
}
