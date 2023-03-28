using Comida_Nivel_Mundial.Carro_de_compras_CL;
using Comida_Nivel_Mundial.Productos_CL;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_Nivel_Mundial
{
    public partial class frmBusquedaComida : Form
    {
        frmInicioCliente iniciocliente; //objeto formaulario
        private string nombre_busqueda;
        private int num_result;
        private int valor_inicial = 0;    //posiciones para el vector
        private int valor_intermedio = 1; //posiciones para el vector
        private int valor_final = 2;      //posiciones para el vector
        private int variante1;
        private int variante2;
        private int variante3;
        private int id_persona;
        //lista_nombres;
        string[] lista_nombres;
        public frmInicioCliente Iniciocliente { get => iniciocliente; set => iniciocliente = value; }

        public frmBusquedaComida(string nombre_comida, string num, string[] nombres, int id_p, frmInicioCliente form)
        {
            InitializeComponent();
            if (form != null)
            {
                Iniciocliente = form;
            }
            id_persona = id_p;
            nombre_busqueda = nombre_comida;
            if (string.IsNullOrWhiteSpace(num) || nombres[0]== "nada")
            {
                txtResult.Text = "No existen Resultado para la busqueda de : " + nombre_comida;
                panel3.Visible = false;
                panel2.Visible = false;
                panel1.Visible = false;
                btnSiguiente.Visible = false;
            }
            else {
                lista_nombres = nombres.Clone() as string[]; //clonar vector
                txtResult.Text = "Resultados de la busqueda de: " + nombre_busqueda + "   Resultados :" + num; //+"ELemento:" +lista_nombres[0]+"Clon: "+ nombres[0];
                num_result = int.Parse(num);
                Obtener_info();
                
            }
        }
        //DESDE AQUI HACER LAS FUNCIONES PARA LLENAR LOS PANELES CON LA INFO DE LAS 3 COMIDAS ENCONTRADAS 
        private void Obtener_info() 
        {
            int indicador = lista_nombres.Length-1;
            if (valor_inicial <= indicador) //panel1
            {
                //consultar sumar 3 veces el valor 
                label1.Text = lista_nombres[valor_inicial];
                valor_inicial = valor_inicial + 3;
                Console.WriteLine(valor_inicial);
                Console.WriteLine(label1.Text);
                //HACER LA CONSULTA DEPENDIENDO DEL NOMBRE DE LA COMIDA
                CComida objComida1 = new CComida(label1.Text);
                textBox1.Text = objComida1.Descripcion;
                txtPrecio1.Text = "$"+objComida1.Precio.ToString();
                txtCategoria1.Text = objComida1.Nombre_categoria;
                txtDesCat1.Text = objComida1.Descripcion_categoria;
                pictureBox16.Image = System.Drawing.Bitmap.FromStream(objComida1.ms);

                variante1 = objComida1.Variante_id;

                //CheckBox chb = (CheckBox)pnlSnakeOptions.Controls["checkBox" + num];
                switch (objComida1.Valoracion)
                {
                    case 5:
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        break;
                    case 4:
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        break;
                    case 3:
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        break;
                    case 2:
                        pictureBox1.Visible = true;
                        pictureBox2.Visible = true;
                        break;
                    case 1:
                        pictureBox1.Visible = true;
                        break;
                    case 0:
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        pictureBox3.Visible = false ;
                        pictureBox4.Visible = false;
                        pictureBox5.Visible = false;
                        break;
                }
            }
            else
            {
                //no consultar, ocultar panel1 y ocultar boton siguiente
                panel1.Visible = false;
                btnSiguiente.Visible = false;
            }
            if (valor_intermedio <= indicador) //panel2
            {
                //consultar sumar 3 veces el valor
                label2.Text = lista_nombres[valor_intermedio];
                valor_intermedio = valor_intermedio  + 3;
                Console.WriteLine(valor_intermedio);
                //HACER LA CONSULTA DEPENDIENDO DEL NOMBRE DE LA COMIDA
                CComida objComida1 = new CComida(label2.Text);
                textBox2.Text = objComida1.Descripcion;
                txtPrecio2.Text = "$" + objComida1.Precio.ToString();
                txtCategoria2.Text = objComida1.Nombre_categoria;
                txtDesCat2.Text = objComida1.Descripcion_categoria;
                pictureBox17.Image = System.Drawing.Bitmap.FromStream(objComida1.ms);
                //CheckBox chb = (CheckBox)pnlSnakeOptions.Controls["checkBox" + num];

                variante2 = objComida1.Variante_id;

                switch (objComida1.Valoracion)
                {
                    case 5:
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox8.Visible = true;
                        pictureBox9.Visible = true;
                        pictureBox10.Visible = true;
                        break;
                    case 4:
                        pictureBox6.Visible = true;
                        pictureBox7.Visible = true;
                        pictureBox8.Visible = true;
                        pictureBox9.Visible = true;
                        break;
                    case 3:
                        pictureBox7.Visible = true;
                        pictureBox8.Visible = true;
                        pictureBox9.Visible = true;
                        break;
                    case 2:
                        pictureBox8.Visible = true;
                        pictureBox9.Visible = true;
                        break;
                    case 1:
                        pictureBox8.Visible = true;
                        break;
                    case 0:
                        pictureBox6.Visible = false;
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = false;
                        break;
                }

            }
            else
            {
                //no consultar, ocultar panel1 y ocultar boton siguiente
                panel2.Visible = false;
                btnSiguiente.Visible = false;
            }
            if (valor_final <= indicador) //panel3
            {
                //consultar sumar 3 veces el valor 
                label3.Text = lista_nombres[valor_final];
                valor_final = valor_final + 3;
                Console.WriteLine(valor_final);
                //HACER LA CONSULTA DEPENDIENDO DEL NOMBRE DE LA COMIDA
                CComida objComida1 = new CComida(label3.Text);
                textBox3.Text = objComida1.Descripcion;
                txtPrecio3.Text = "$" + objComida1.Precio.ToString();
                txtCategoria3.Text = objComida1.Nombre_categoria;
                txtDesCat3.Text = objComida1.Descripcion_categoria;
                pictureBox18.Image = System.Drawing.Bitmap.FromStream(objComida1.ms);

                variante3 = objComida1.Variante_id;


                //CheckBox chb = (CheckBox)pnlSnakeOptions.Controls["checkBox" + num];
                switch (objComida1.Valoracion)
                {
                    case 5:
                        pictureBox11.Visible = true;
                        pictureBox12.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = true;
                        pictureBox15.Visible = true;
                        break;
                    case 4:
                        pictureBox11.Visible = true;
                        pictureBox12.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = true;
                        break;
                    case 3:
                        pictureBox12.Visible = true;
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = true;
                        break;
                    case 2:
                        pictureBox13.Visible = true;
                        pictureBox14.Visible = true;
                        break;
                    case 1:
                        pictureBox12.Visible = true;
                        break;
                    case 0:
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                        pictureBox13.Visible = false;
                        pictureBox14.Visible = false;
                        pictureBox15.Visible = false;
                        break;
                }

            }
            else
            {
                //no consultar, ocultar panel1 y ocultar boton siguiente
                panel3.Visible = false;
                btnSiguiente.Visible = false;
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Obtener_info();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPedir1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox_Si_NO(this.Iniciocliente);
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                MessageBox.Show("Añadir");
                //AQUI AÑADIR AL CARRITO XD 
                CCarritoCompras objCarrito2 = new CCarritoCompras(id_persona, variante1); //aqui enviar el id del cliente y el id de la varainte a añadir 
                if (objCarrito2.Añadir_Carrito())
                   notificaciones.EnabledNoti = Enabled;
                else
                    MessageBox.Show("Ocurrio un error");
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No hay presupuesto para programar este boton");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox_Si_NO(this.Iniciocliente);
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                MessageBox.Show("Añadir");
                //AQUI AÑADIR AL CARRITO XD 
                CCarritoCompras objCarrito2 = new CCarritoCompras(id_persona, variante2); //aqui enviar el id del cliente y el id de la varainte a añadir 
                if (objCarrito2.Añadir_Carrito())
                    notificaciones.EnabledNoti = Enabled;
                else
                    MessageBox.Show("Ocurrio un error");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(id_persona.ToString() + "" + variante3.ToString());

            DialogResult resultado = new DialogResult();
            Form mensaje = new MessageBox_Si_NO(this.Iniciocliente);
            resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK) //ELIMINAR
            {
                MessageBox.Show("Añadir");
                //AQUI AÑADIR AL CARRITO XD 
                CCarritoCompras objCarrito2 = new CCarritoCompras(id_persona, variante3); //aqui enviar el id del cliente y el id de la varainte a añadir 
                if (objCarrito2.Añadir_Carrito())
                    notificaciones.EnabledNoti = Enabled;
                else
                    MessageBox.Show("Ocurrio un error");
            }
        }
    }
}
