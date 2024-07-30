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
    public partial class IngresoDeDatos : Form
    {
        public IngresoDeDatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblPrimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuarRegistrodedatos_Click(object sender, EventArgs e)
        {
           
        if (ValidarDatos1())
            {
                MenuPrincipalTest menuPrincipalTest = new MenuPrincipalTest();
                menuPrincipalTest.Show();
                this.Hide();
            }
  
        }

        private bool ValidarDatos1()
        {
            if (string.IsNullOrEmpty(txtPirmerNombre.Text))
            {
                MessageBox.Show("Por favor ingrese su primer nombre ");
                return false;
            }

            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                MessageBox.Show("Por favor ingrese su primer Apellido ");
                return false;
            }
           
            if (string.IsNullOrEmpty(txtNumeroDocumento.Text))
            {
                MessageBox.Show("Por favor digite su numero de documento");
                return false;
            }
            if (cboDepartamentoResidencia.SelectedIndex == -1)
            {
                MessageBox.Show("por favor seleccione un Departamento");
                return false;
            }
            if (cboMunicipioDeResidencia.SelectedIndex == -1)
            {
                MessageBox.Show("por favor seleccione un Municipio");
                return false;
            }
            if (string.IsNullOrEmpty(txtDirecciónResidencia.Text))
            {
                MessageBox.Show("Por favor indique su Dirección de residencia ");
                return false;
            }
            if (dtpFechaNacimiento.Value > DateTime.Today)
            {
                MessageBox.Show("la fecha de nacimeinto no puede ser en el futuro");
                return false;
            }
            
            return true;

        

        }

        private void btnContinuarRegistrodedatos1(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                return;
            }
        }

        private bool ValidarDatos()
        {
            throw new NotImplementedException();
        }

        private void txtDirecciónResidencia_TextChangjed(object sender, EventArgs e)
        {

        }

        private void txtNumeroDocumento_Keypress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
