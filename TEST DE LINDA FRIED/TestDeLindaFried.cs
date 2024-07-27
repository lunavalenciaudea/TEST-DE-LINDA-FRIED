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
            List<string> respuestas = ObtenerRespuestas();
            RespuestasTest respuestasTest = new RespuestasTest(respuestas);
            respuestasTest.ShowDialog();

        }
        private List<string> ObtenerRespuestas()

        {
            List<string> respuestas = new List<string>();
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta1));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta2));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta3));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta4));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta5));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta6));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta7));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta8));
            respuestas.Add(ObtenerRespuestaGroupBox(gbPregunta9));
            return respuestas;

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
    }
}

