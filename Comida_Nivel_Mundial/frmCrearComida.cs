using Comida_Nivel_Mundial.Productos_CL;
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
    public partial class frmCrearComida : Form
    {
        public frmCrearComida()
        {
            InitializeComponent();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Fo = new OpenFileDialog();
                DialogResult Rs = Fo.ShowDialog();
                if (Rs == DialogResult.OK)
                {
                    picFoto.Image = Image.FromFile(Fo.FileName);
                }
            }
            catch (Exception en)
            {
                MessageBox.Show("No se admite este archivo :"+en.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //ya funka solo falta validar y borrar los campos xd 
            try {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                CComida objComida = new CComida(txtnombre.Text, txtdescripcion.Text, double.Parse(txtprecio1.Text + "." + txtprecio2.Text), int.Parse(txtPais.Text), int.Parse(txtCategoria.Text), ms.GetBuffer());
                MessageBox.Show("Se agrego");

            }
            catch (Exception ne) { MessageBox.Show(ne.Message); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCrearComida_Load(object sender, EventArgs e)
        {

        }
    }
}
