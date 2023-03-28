using Comida_Nivel_Mundial.Carro_de_compras_CL;
using Comida_Nivel_Mundial.Entregas_CL;
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
    public partial class frmInicioCliente : Form
    {
        private int id_persona;
        public frmInicioCliente(int id_p)
        {
            InitializeComponent();
            id_persona = id_p;
            dtgvBusqueda.ColumnHeadersVisible = false;
            AbrirFormulario(new frmHome_Cliente());
            CCarritoCompras carrito = new CCarritoCompras(id_persona);
            txtprecio.Text = carrito.Numero_de_elementos.ToString();
            VER_Mapa();
        }

        private void frmInicioCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string numero_resultados="0";

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                csListarBusqueda obcom = new csListarBusqueda();
                obcom.PalabraClave = txtBusqueda.Text;
                dtgvBusqueda.DataSource = obcom.listarpro();


                    numero_resultados = obcom.numerosResultados;
                if (dtgvBusqueda.Rows.Count == 0)
                {
                    panel1.Visible = false;
                }
            }
        }
        private int posicion;
        private int fila;
        public void Numero_Carrito()
        {
            txtprecio.Text = ((int.Parse(txtprecio.Text)) + 1).ToString();
        }
        private void dtgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                posicion = dtgvBusqueda.CurrentRow.Index;
                fila = e.RowIndex;
                int columna = e.ColumnIndex;
                txtBusqueda.Text = (dtgvBusqueda[0, posicion].Value.ToString());
                panel1.Visible = false;

                //Enviar un vector al nuevo formulario para recorrer la wea fobe xd 

                csListarBusqueda obcom = new csListarBusqueda();
                obcom.PalabraClave = txtBusqueda.Text;
                dtgvBusqueda.DataSource = obcom.listarpro();
                int numero_resultados_ar = int.Parse(obcom.numerosResultados);
                String[] variable_name = new String[numero_resultados_ar];
                for (int i = 0; i < dtgvBusqueda.RowCount; i++)
                {
                    variable_name[i] = dtgvBusqueda.Rows[i].Cells[0].Value.ToString();
                    Console.WriteLine(variable_name[i]);
                }



                AbrirFormulario(new frmBusquedaComida(txtBusqueda.Text, numero_resultados,variable_name,id_persona,this)); ///OJITO AQUI PUEDE HABER UN ERROR XD 
            }
            catch (Exception ne) { }
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
        public void Verboton() { btnPediso.Visible = true; }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
 
                csListarBusqueda obcom = new csListarBusqueda();
                obcom.PalabraClave = txtBusqueda.Text;
                dtgvBusqueda.DataSource = obcom.listarpro();
            if (obcom.numerosResultados != "0")
            {
                int numero_resultados_ar = int.Parse(obcom.numerosResultados); //Aqui esta el problema
                String[] variable_name_1 = new String[numero_resultados_ar];
                for (int i = 0; i < dtgvBusqueda.RowCount; i++)
                {
                    variable_name_1[i] = dtgvBusqueda.Rows[i].Cells[0].Value.ToString();
                    Console.WriteLine(variable_name_1[i]);
                }
                AbrirFormulario(new frmBusquedaComida(txtBusqueda.Text, numero_resultados, variable_name_1, id_persona,this));

            }
            else
            {
                String[] variable_name = { "nada" };
                AbrirFormulario(new frmBusquedaComida(txtBusqueda.Text, numero_resultados, variable_name, id_persona, this));
            }
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmHome_Cliente());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void uI_ShadowPanel4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCarrito(id_persona,this));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           //aqui abrir el mapa con el envio xd 
           //Hay que verficiar que no puede tener dos envios 
           //solo puede hacer un envio 
        }
        public void VER_Mapa() 
        {
            CEnvios objEstado = new CEnvios();
            int ac=objEstado.VerEstado(id_persona);
            if (ac == 1)
            {
                //Se esta cocinando
                uI_ShadowPanel3.Visible = false;
                panel1.Visible = false;
                uI_ShadowPanel2.Visible = false;
                uI_ShadowPanel1.Visible = false;
                uI_ShadowPanel6.Visible = false;
                panel3.Visible = false;
                uI_ShadowPanel5.Visible = false;
                AbrirFormulario(new frmCocinado());
            }
            else if (ac == 2) 
            {
                uI_ShadowPanel3.Visible = false;
                panel1.Visible = false;
                uI_ShadowPanel2.Visible = false;
                uI_ShadowPanel1.Visible = false;
                uI_ShadowPanel6.Visible = false;
                panel3.Visible = false;
                uI_ShadowPanel5.Visible = false;
                AbrirFormulario(new frmMapaCliente(id_persona));
            }
        }
    }
}
