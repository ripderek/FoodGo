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
    internal class CComida
    {
        CsConexion conexion = new CsConexion();
        public MemoryStream ms; //byts para la foto
        private int id_comida;
        private string nombre_comida;
        private byte[] foto;
        private int categoria;
        private int pais_origen;
        private string porciones;
        private string descripcion;
        private string semaforo_nutricional;
        private string puntuacion;
        private byte estado;
        private string tipo;
        private double precio;
        private string pais;
        private string descripcion_categoria;
        private int variante_id;
        private int valoracion;
        private string nombre_categoria;

        public int Id_comida { get => id_comida; set => id_comida = value; }
        public string Nombre_comida { get => nombre_comida; set => nombre_comida = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Pais_origen { get => pais_origen; set => pais_origen = value; }
        public string Porciones { get => porciones; set => porciones = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Semaforo_nutricional { get => semaforo_nutricional; set => semaforo_nutricional = value; }
        public string Puntuacion { get => puntuacion; set => puntuacion = value; }
        public byte Estado { get => estado; set => estado = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Descripcion_categoria { get => descripcion_categoria; set => descripcion_categoria = value; }
        public int Variante_id { get => variante_id; set => variante_id = value; }
        public int Valoracion { get => valoracion; set => valoracion = value; }
        public string Nombre_categoria { get => nombre_categoria; set => nombre_categoria = value; }

        //constructor vacio 
        public CComida() { }
        //Sobrecargar del constructor para registrar una comida y su primer variante
        public CComida(string nombreP, string descripcionP, double precioP, int paisP, int categoriaP, byte[] pic) {
            Nombre_comida = nombreP; Descripcion = descripcionP; Precio = precioP;  Pais_origen = paisP; Categoria = categoriaP; foto = pic;
            registrar_comida();
            Registrar_Variante_();
        }
        //Sobrecarga del constructor para obtener la info de la comida segun el nombre
        public CComida(string nombr) 
        {
            Nombre_comida = nombr;
            ver_datos_comida();
            ImagenComida();
        }
        private void registrar_comida( )
        {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Crear_Comida", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Nombre", Nombre_comida);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Precio_General", Precio);
                cmd.Parameters.AddWithValue("@Pais", Pais_origen);
                cmd.Parameters.AddWithValue("@Imagen", foto);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                //Cerrar conexion
                conexion.abrirCerrarConexion();
            }
            catch (Exception en)
            {
                MessageBox.Show("Error:  "+en.Message);
            }
        }
        //registrar primer variante de la comida 
        private void Registrar_Variante_() {
            try
            {
                //SqlCommand->Ejecutar una sentencia SQL
                SqlCommand cmd = new SqlCommand("SP_Agregar_Variante", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Nombre", Nombre_comida);
                cmd.Parameters.AddWithValue("@Precio_General", Precio);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@Image", foto);
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
        private void modificar_comida() { }
        private void eliminar_comida() { }
        private void cambiar_estado() { }
        private void calcular_puntuacion() { }
        private void ver_datos_comida() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Paneles_Comida", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@nombre", Nombre_comida);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Descripcion = rd.GetString(0);
                    Precio = double.Parse(rd.GetDecimal(1).ToString("N2"));//si da error cambiar a decimal
                    Pais = rd.GetString(2);
                    Nombre_categoria = rd.GetString(3);
                    Descripcion_categoria = rd.GetString(4);
                    Variante_id = rd.GetInt32(5);
                    Id_comida = rd.GetInt32(6);
                    Valoracion = rd.GetInt32(7);
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
        private void ImagenComida() 
        {
            try
            {

                SqlCommand cmd = new SqlCommand("SP_Foto_Comida", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@nombre", Nombre_comida);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet("imagen");
                dp.Fill(ds, "imagen");
                byte[] Datos = new byte[0];
                DataRow DR = ds.Tables["imagen"].Rows[0];
                Datos = (byte[])DR["imagen"];
                ms = new MemoryStream(Datos);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "!!Advertencia!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
