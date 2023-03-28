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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CUsuario objUsuario = new CUsuario(txtUsuario.Text,txtContrasenia.Text);
            if (objUsuario.VerficarSesion())
            { MessageBox.Show("Correcto" + " " + objUsuario.TipoUsuario);
                switch (objUsuario.TipoUsuario) {
                    case "Cliente":
                        frmInicioCliente InicioCliente = new frmInicioCliente(objUsuario.Id_persona);
                        InicioCliente.Show();
                        this.Hide();
                        break;
                    case "Administrador":
                        frmInicioAdministrador Administrador = new frmInicioAdministrador();
                        Administrador.Show();
                        this.Hide();
                        break;
                    case "Repartidor":
                        frmInicioRepartidor repartidor = new frmInicioRepartidor(objUsuario.Id_persona);
                        repartidor.Show();
                        this.Hide();
                        break;
                }
            }
            else
                MessageBox.Show("Incorrecto");
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                BtnVer.Visible = false;
                btnNover.Visible = false;
            }

            else
            {
                btnNover.Visible = true; BtnVer.BringToFront();
            }
        }

        private void uI_ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNover_Click(object sender, EventArgs e)
        {
            BtnVer.Visible = true; BtnVer.BringToFront();
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            btnNover.Visible = true; btnNover.BringToFront();
            BtnVer.Visible = false;
            txtContrasenia.UseSystemPasswordChar = false;
        }
    }
}
