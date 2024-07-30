using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_DE_LINDA_FRIED
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
            string usuarioValido = "usuario";
            string contraseñaValida = "contraseña";

            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;

            if (usuarioIngresado == usuarioValido && contraseñaIngresada == contraseñaValida)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            

        IngresoDeDatos ingresoDeDatos = new IngresoDeDatos();
        ingresoDeDatos.Show();
        this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e) 
        {
           
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
           
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.UseSystemPasswordChar = true;

        }
    }
}
