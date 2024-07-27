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
    public partial class RespuestasTest : Form
    {
        private List<string> respuestas;
        private string categoria;

        public RespuestasTest()
        {
            InitializeComponent();
        }

        public RespuestasTest(List<string> respuestas, int cantidadSi, int cantidadNo)
        {
            this.respuestas = respuestas;
        }

        public RespuestasTest(List<string> respuestas, ListBox listBox)
        {
            this.respuestas = respuestas;
            InitializeComponent();
            MostrarRespuestas();

        }

        public RespuestasTest(List<string> respuestas, int cantidadSi, int cantidadNo, string categoria) : this(respuestas, cantidadSi, cantidadNo)
        {
            this.categoria = categoria;
        }

        public RespuestasTest(List<string> respuestas)
        {
            this.respuestas = respuestas;
        }

        private void MostrarRespuestas()
        {

            listBoxRespuestas.Items.Clear();


            foreach (string respuesta in respuestas)
            {
                listBoxRespuestas.Items.Add(respuesta);
            }
        }

       
    }
}
