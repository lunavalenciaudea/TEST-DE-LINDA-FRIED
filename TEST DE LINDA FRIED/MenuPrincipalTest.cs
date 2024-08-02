using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_DE_LINDA_FRIED
{
    public partial class MenuPrincipalTest : Form
    {
        public MenuPrincipalTest()
        {
            InitializeComponent();
            EstilizarFormulario();
        }
        private void EstilizarFormulario()
        {
            // Fondo del formulario
            this.BackColor = System.Drawing.Color.FromArgb(249, 249, 249); // Blanco Hueso

            // Título (lblMenuPrincipal)
            lblMenuPrincipal.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuPrincipal.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            // Botón Continuar (btnContinuarMenu)
            btnContinuarMenu.FlatStyle = FlatStyle.Flat;
            btnContinuarMenu.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro
            btnContinuarMenu.ForeColor = System.Drawing.Color.White; // Texto blanco
            btnContinuarMenu.FlatAppearance.BorderSize = 0;
            btnContinuarMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuarMenu.MouseEnter += (s, e) => btnContinuarMenu.BackColor = System.Drawing.Color.FromArgb(22, 160, 133); // Turquesa Oscuro al pasar el ratón
            btnContinuarMenu.MouseLeave += (s, e) => btnContinuarMenu.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro original

            // GroupBox (gpbGrupoMenuP)
            gpbGrupoMenuP.BackColor = System.Drawing.Color.FromArgb(234, 234, 234); // Gris Claro
            gpbGrupoMenuP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gpbGrupoMenuP.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbRealizarTest_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnContinuarMenu_Click(object sender, EventArgs e)
        {
            if (rdbRealizarTest.Checked)
            {
               
                TESTDELINDAFRIED tESTDELINDAFRIED = new TESTDELINDAFRIED();
                tESTDELINDAFRIED.ShowDialog();
                this.Hide();
            }
            else if (rdbVolverInicio.Checked)
            {
                
                InicioDeSesion inicioDeSesion = new InicioDeSesion();
                inicioDeSesion.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecciona una opción antes de continuar.");
            }
            this.Hide();
        }
    }
}

