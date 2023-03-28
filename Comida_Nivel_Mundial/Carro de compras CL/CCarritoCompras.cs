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

namespace Comida_Nivel_Mundial.Carro_de_compras_CL
{
    internal class CCarritoCompras
    {
        CsConexion conexion = new CsConexion();
        private int id_compra;
        private int id_cliente;
        private double total;
        private int variante_comida;
        private long numero_de_elementos;
        public int Id_compra { get => id_compra; set => id_compra = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public double Total { get => total; set => total = value; }
        public int Variante_comida { get => variante_comida; set => variante_comida = value; }
        public long Numero_de_elementos { get => numero_de_elementos; set => numero_de_elementos = value; }

        //COnstructor para añadir al carrito 
        public CCarritoCompras( int per, int var)
        {
            Id_cliente = per; Variante_comida = var;
        }
        //sobrecarga para ver el numero de elementos en el carrito de compras 
        public CCarritoCompras(int per)
        {
            Id_cliente = per;
            NumElemen();
        }
        private void pagar_carrito() { }
        private void calcular_total() { }
        private void eliminar_carrito() { }
        public bool Añadir_Carrito() 
        {
            bool ac = false;
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Ingresar_Carrito", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_Persona", Id_cliente);
                cmd.Parameters.AddWithValue("@id_variante", Variante_comida);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
                ac = true;
            }
            catch (Exception en)
            {
                MessageBox.Show("Error:  " + en.Message);
            }
            return ac;
        }
        private void NumElemen() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_N_Carrito", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_Persona", Id_cliente);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Numero_de_elementos = rd.GetInt64(0);
                    //decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                    // Identificacion_Persona = rd.GetString(0);

                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();

            }
            catch (Exception n)
            {
                MessageBox.Show("AQUI "+n.Message);
            }
        }
    }
}
