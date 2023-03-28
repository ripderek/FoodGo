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
    internal class CEmpleados:CUsuario
    {
        CsConexion conexion = new CsConexion();
        private int id_empleado;
        private double sueldo;
        private string cargo;
        private string area;
        private byte estado;
        private int id_persona;
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Area { get => area; set => area = value; }
        public byte Estado1 { get => estado; set => estado = value; }
        public int Id_persona1 { get => id_persona; set => id_persona = value; }

        public CEmpleados(int idp) 
        {
            Id_persona1 = idp;
            ID_empleado();
        }
        private void registrar_empleado() { }
        private void modificar_empleado() { }
        private void eliminar_empleado() { }
        private void cambiar_estado() { }
        private void ID_empleado() 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_Id_Empleado", conexion.con);
                cmd.CommandType = CommandType.StoredProcedure;
                //Abrir conexion
                conexion.abrirCerrarConexion();
                //Asignar parámetros
                cmd.Parameters.AddWithValue("@id_persona", Id_persona1);
                //Ejecutar procedure
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    // Descripcion = rd.GetString(0);
                    Id_empleado = rd.GetInt32(0);
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
    }
}
