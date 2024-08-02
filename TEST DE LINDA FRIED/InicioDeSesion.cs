using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            EstilizarFormulario();
        }
        private void EstilizarFormulario()
        {
            this.BackColor = System.Drawing.Color.FromArgb(249, 249, 249); // Blanco Hueso

            // Botón Principal (btnAceptar)
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro
            btnAceptar.ForeColor = System.Drawing.Color.White; // Texto blanco
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.MouseEnter += (s, e) => btnAceptar.BackColor = System.Drawing.Color.FromArgb(22, 160, 133); // Turquesa Oscuro al pasar el ratón
            btnAceptar.MouseLeave += (s, e) => btnAceptar.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro original

            // Label de Título (lblIninicoDeSesion)
            lblIninicoDeSesion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point); // Más grande y en negrita
            lblIninicoDeSesion.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            // Labels para cajas de texto
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point); // Negrita y más grande
            lblUsuario.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            lblContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point); // Negrita y más grande
            lblContraseña.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            // Cajas de Texto (txtUsuario y txtContraseña)
            txtUsuario.BackColor = System.Drawing.Color.White; // Blanco
            txtUsuario.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            txtContraseña.BackColor = System.Drawing.Color.White; // Blanco
            txtContraseña.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
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
