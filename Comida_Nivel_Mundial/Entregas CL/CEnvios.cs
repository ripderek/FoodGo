using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comida_Nivel_Mundial.Productos_CL;

namespace Comida_Nivel_Mundial.Entregas_CL
{
    internal class CEnvios
    {
        private int id_factura;
        private int id_empleado;
        private string latitud;
        private string longitud;
        private string estado;
        CsConexion conexion = new CsConexion();

        private string nombres;
        private string n_celular;
        private string ubi1entrega;
        private string ubi2entrega;
        private string entregabui1;
        private string entregabui2;
        private int factura_id;
        private int envios_id;

        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Latitud { get => latitud; set => latitud = value; }
        public string Longitud { get => longitud; set => longitud = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string N_celular { get => n_celular; set => n_celular = value; }
        public string Ubi1entrega { get => ubi1entrega; set => ubi1entrega = value; }
        public string Ubi2entrega { get => ubi2entrega; set => ubi2entrega = value; }
        public string Entregabui1 { get => entregabui1; set => entregabui1 = value; }
        public string Entregabui2 { get => entregabui2; set => entregabui2 = value; }
        public int Factura_id { get => factura_id; set => factura_id = value; }
        public int Envios_id { get => envios_id; set => envios_id = value; }
        public string Estado { get => estado; set => estado = value; }

        public CEnvios(int id_fac, int idem, string lat, string lon) 
        {
            Id_factura = id_fac; Id_empleado = idem; Latitud = lat; Longitud = lon; 
            Registrar_envio();
        }
        public CEnvios() 
        {
          
        }
        public void cambiar_estado(int idem)
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Cambiar_Estado_Envio", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_envio", idem);
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
        private void Registrar_envio() 
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Crear_Pedido", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@ID_factura", Id_factura);
                cmd.Parameters.AddWithValue("@ID_Empleado", Id_empleado);
                cmd.Parameters.AddWithValue("@Latitud", Latitud);
                cmd.Parameters.AddWithValue("@Longiturd", Longitud);
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
        private void actualizar_ubicacion_repartidor() { }
        public bool ver_datos_envio(int idem)
        {
            bool pase=false;
            try
            {
                SqlCommand cmd = new SqlCommand("SP_VER_DATOS_ENVIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_empleado", idem);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    pase = true;
                    Console.WriteLine("Antes del WHile");
                    while (rd.Read())
                    {
                        Console.WriteLine("Despues del WHile");

                        Nombres = rd.GetString(0) + rd.GetString(1);
                        N_celular = rd.GetString(2);
                        Ubi1entrega = rd.GetString(3);
                        Ubi2entrega = rd.GetString(4);
                        Entregabui1 = rd.GetString(5);
                        Entregabui2 = rd.GetString(6);
                        Id_factura = rd.GetInt32(7);
                        Envios_id = rd.GetInt32(8);
                        Console.WriteLine(nombres);
                        //decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                        // Identificacion_Persona = rd.GetString(0);
                    }
                }


                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();
                datos(idem);
            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
            return pase; 
        }
        private void datos(int idem) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_VER_DATOS_ENVIO", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_empleado", idem);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("Despues del WHile");
                    Nombres = rd.GetString(0) + rd.GetString(1);
                    N_celular = rd.GetString(2);
                    Ubi1entrega = rd.GetString(3);
                    Ubi2entrega = rd.GetString(4);
                    Entregabui1 = rd.GetString(5);
                    Entregabui2 = rd.GetString(6);
                    Id_factura = rd.GetInt32(7);
                    Envios_id = rd.GetInt32(8);
                    Console.WriteLine(nombres);
                    //decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                    // Identificacion_Persona = rd.GetString(0);
                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();

            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }
        public void Datos_CLiente( int idem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_VER_DATOS_Cliente", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_empleado", idem);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("Despues del WHile");
                    Nombres = rd.GetString(0) + " " +rd.GetString(1);
                    N_celular = rd.GetString(2);
                    Ubi1entrega = rd.GetString(3);
                    Ubi2entrega = rd.GetString(4);
                    Entregabui1 = rd.GetString(5);
                    Entregabui2 = rd.GetString(6);
                    Id_factura = rd.GetInt32(7);
                    Envios_id = rd.GetInt32(8);
                    Console.WriteLine(nombres);
                    //decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                    // Identificacion_Persona = rd.GetString(0);
                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();

            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
        }
        public int VerEstado(int idem) 
        {
            int ac = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SP_VER_Estado", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@persona", idem);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("Despues del WHile");
                    Estado = rd.GetString(0);
                    Console.WriteLine(nombres);
                    //decimal.Parse(dr.GetDecimal(2).ToString("N2"));
                    // Identificacion_Persona = rd.GetString(0);
                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();
                Console.WriteLine(Estado+ac.ToString());
                if (Estado == "En recepcion")
                    ac = 1;
                else if (Estado == "En envio")
                    ac = 2;
                Console.WriteLine(Estado + ac.ToString());


            }
            catch (Exception n)
            {
                MessageBox.Show(n.Message);
            }
            return ac;
        }
    }
}
