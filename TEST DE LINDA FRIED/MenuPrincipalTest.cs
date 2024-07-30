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

