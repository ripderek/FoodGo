using Comida_Nivel_Mundial.Entregas_CL;
using Comida_Nivel_Mundial.Usuarios_Aplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_Nivel_Mundial
{
    public partial class frmInicioRepartidor : Form
    {
        private int id_empleado_repartidor;
        public frmInicioRepartidor(int id_per)
        {
            InitializeComponent();       
            //obtener el id del repartidor 
            CEmpleados pbjempleado = new CEmpleados(id_per);
            id_empleado_repartidor = pbjempleado.Id_empleado;
            MessageBox.Show(id_empleado_repartidor.ToString());
            //AbrirFormulario(new frmOrdenesEnvios(this, id_empleado_repartidor));
            AbrirMapaRe();
        }

        private void frmInicioRepartidor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPediso_Click(object sender, EventArgs e)
        {
            //VER LOS PEDIDOS LISTOS PARA ENVIAR 
            AbrirFormulario(new frmOrdenesEnvios(this,id_empleado_repartidor));

        }
        private Form formularioActivo = null;
        public void AbrirFormulario(Form nuevoFormulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            panel_pantalla.Controls.Add(nuevoFormulario);
            panel_pantalla.Tag = nuevoFormulario;
            // nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }
        public void AbrirMapaRe() 
        {
            CEnvios map_envio = new CEnvios();
            if (map_envio.ver_datos_envio(id_empleado_repartidor))
            {
                AbrirFormulario(new frmMapaRepartidor(id_empleado_repartidor,this)); //ESTE FORMULARIO DEBE HACER LA CONSULTA DE NUEVO PARA PODER ACTUALIZAR EN TIEMPO REAL LOS DATOS
                btnMapa.Visible = true;
                btnPediso.Visible = false;
            }
            else
            {  AbrirFormulario(new frmOrdenesEnvios(this, id_empleado_repartidor)); btnPediso.Visible = true;
            }
        }
        public void Finalizar() 
        {
            AbrirFormulario(new frmOrdenesEnvios(this, id_empleado_repartidor));
            btnPediso.Visible = true;
            btnMapa.Visible = false;
        }
    }
}
