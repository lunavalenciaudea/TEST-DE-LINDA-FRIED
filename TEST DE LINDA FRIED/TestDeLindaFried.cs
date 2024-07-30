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
    public partial class TESTDELINDAFRIED : Form
    {
        public TESTDELINDAFRIED()
        {
            InitializeComponent();
        }

        private void lblPregunta9_Click(object sender, EventArgs e)
        {

        }

        private void TESTDELINDAFRIED_Load(object sender, EventArgs e)
        {

        }

        private void rdbSi1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarTest_Click(object sender, EventArgs e)
        {

            int numeroSi= int.Parse(txtRespuestasSI.Text);
            int numeroNo= int.Parse(txtRespuestasNO.Text);
            RespuestasTest respuestasTest = new RespuestasTest(numeroSi);
            respuestasTest.ShowDialog();
            this.Hide();

        }
       
        private string ObtenerRespuestaGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    if (radioButton.Name.StartsWith("rdbSi"))
                    {
                        return "Si";
                    }
                    else if (radioButton.Name.StartsWith("rdbNo"))
                    {
                        return "No";
                    }
                }
            }
            return "No contestado";
        }

        private void txtRespuestasSI_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtRespuestasNO_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}

