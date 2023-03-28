using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace Comida_Nivel_Mundial.Usuarios_Aplicacion
{
    internal class CUsuario
    {
        private int id_usuario;
        private string dni;
        private string nombres;
        private string apellidos;
        private string fecha_nacimiento;
        private string numero_celular;
        private string genero;
        private byte estado;
        private string nacionalidad;
        private string pais_actual;
        private string ciudad_actual;
        private string tipo_usuario;
        private string fecha_creacion;
        private string username;
        private string correo;
        private string pregunta_seguridad;
        private string respuesta_seguridad;
        private string contrena;
        private string tipoUsuario;
        private int id_persona;
        CsConexion conexion = new CsConexion();

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Numero_celular { get => numero_celular; set => numero_celular = value; }
        public string Genero { get => genero; set => genero = value; }
        public byte Estado { get => estado; set => estado = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Pais_actual { get => pais_actual; set => pais_actual = value; }
        public string Ciudad_actual { get => ciudad_actual; set => ciudad_actual = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Fecha_creacion { get => fecha_creacion; set => fecha_creacion = value; }
        public string Username { get => username; set => username = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Pregunta_seguridad { get => pregunta_seguridad; set => pregunta_seguridad = value; }
        public string Respuesta_seguridad { get => respuesta_seguridad; set => respuesta_seguridad = value; }
        public string Contrena { get => contrena; set => contrena = value; }
        public string TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public int Id_persona { get => id_persona; set => id_persona = value; }

        //Constructor vacio
        public CUsuario() { 
        }
        //Sobrecarga del Constructor para verficar el usuario que solo admita como parametro el username, correo y contrasena
        public CUsuario(string nombre_usuario, string contra) { 
            Correo = nombre_usuario;
            Contrena = contra;
        }
        public bool VerficarSesion() {
            bool pase = false;
       //     try
         //   {
                SqlCommand cmd = new SqlCommand("SP_Verificar_Sesion", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;

                //Abrir conexion
                conexion.abrirCerrarConexion();

                //Asignar parámetros
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Contrasena", Contrena);

                //Ejecutar procedure
                cmd.ExecuteNonQuery();

                SqlDataReader rd = cmd.ExecuteReader();

                //private int Estado;
                // private string Ocupacion;
                while (rd.Read())
                {
                    pase = Boolean.Parse(rd.GetString(0));
                    TipoUsuario = rd.GetString(1);
                    Id_persona = rd.GetInt32(2);

                }
                //Cerrar conexion
                conexion.abrirCerrarConexion();
                rd.Close();
                //Retornar un boolean
                
           // }
           //catch (Exception n)
          //  {
         //       MessageBox.Show(n.Message);
         //   }
            return pase;
        }
        private void registrar_usuario() { }
        private void modificar_usuario() { }
        private void eliminar_usuario() { }
        private bool cambiar_estado() { return true; }
        public void ver_datos() { }
        private void calcular_edad() { }
        private void recuperar_contrasena() { }
        private void cambiar_contrasena() { }
        private void otorgar_permisos() { }
    }
}
