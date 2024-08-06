using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TEST_DE_LINDA_FRIED
{
    public partial class TESTDELINDAFRIED : Form
    {
        public TESTDELINDAFRIED()
        {
            InitializeComponent();
            EstilizarFormulario();
        }

        private void EstilizarFormulario()
        {
            // Fondo del formulario
            this.BackColor = System.Drawing.Color.FromArgb(249, 249, 249); // Blanco Hueso

            // Título (lblTitulo)
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            // Labels (lblPrimer, lblSegunda, lblTercera, lblCuarta, ...)
            EstilizarLabels();

            // Botón Guardar (btnGuardarTest)
            btnGuardarTest.FlatStyle = FlatStyle.Flat;
            btnGuardarTest.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro
            btnGuardarTest.ForeColor = System.Drawing.Color.White; // Texto blanco
            btnGuardarTest.FlatAppearance.BorderSize = 0;
            btnGuardarTest.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarTest.MouseEnter += (s, e) => btnGuardarTest.BackColor = System.Drawing.Color.FromArgb(22, 160, 133); // Turquesa Oscuro al pasar el ratón
            btnGuardarTest.MouseLeave += (s, e) => btnGuardarTest.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro original

            // Botón Volver (btnVolverAlInicio)
            btnVolverAlInicio.FlatStyle = FlatStyle.Flat;
            btnVolverAlInicio.BackColor = System.Drawing.Color.FromArgb(243, 156, 18); // Naranja Suave
            btnVolverAlInicio.ForeColor = System.Drawing.Color.White; // Texto blanco
            btnVolverAlInicio.FlatAppearance.BorderSize = 0;
            btnVolverAlInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverAlInicio.MouseEnter += (s, e) => btnVolverAlInicio.BackColor = System.Drawing.Color.FromArgb(230, 126, 34); // Naranja Intenso al pasar el ratón
            btnVolverAlInicio.MouseLeave += (s, e) => btnVolverAlInicio.BackColor = System.Drawing.Color.FromArgb(243, 156, 18); // Naranja Suave original

            // GroupBoxes (gbPregunta1, gbPregunta2, ..., gbPregunta9)
            EstilizarGroupBoxes();

            // Labels de Preguntas (lblPregunta1, lblPregunta2, ..., lblPregunta9)
            EstilizarLabelsDePreguntas();
        }
        private void EstilizarLabels()
        {
            // Labels (lblPrimer, lblSegunda, lblTercera, lblCuarta, ...)
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.StartsWith("lbl"))
                {
                    label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point); // Negrita y más grande
                    label.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
                }
            }
        }

        private void EstilizarLabelsDePreguntas()
        {
            // Labels de Preguntas (lblPregunta1, lblPregunta2, ..., lblPregunta9)
            for (int i = 1; i <= 9; i++)
            {
                Label lblPregunta = (Label)this.Controls.Find($"lblPregunta{i}", true).FirstOrDefault();
                if (lblPregunta != null)
                {
                    lblPregunta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point); // Negrita y más grande
                    lblPregunta.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
                }
            }
        }

        private void EstilizarGroupBoxes()
        {
            // GroupBoxes (gbPregunta1, gbPregunta2, ..., gbPregunta9)
            for (int i = 1; i <= 9; i++)
            {
                System.Windows.Forms.GroupBox gbPregunta = (System.Windows.Forms.GroupBox)this.Controls.Find($"gbPregunta{i}", true).FirstOrDefault();
                if (gbPregunta != null)
                {
                    gbPregunta.BackColor = System.Drawing.Color.FromArgb(234, 234, 234); // Gris Claro
                    gbPregunta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                    gbPregunta.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
                }
            }
        }

        private void btnGuardarTest_Click(object sender, EventArgs e)
        {
            var preguntas = new (System.Windows.Forms.RadioButton si, System.Windows.Forms.RadioButton no)[]
            {
                (rdbSi1, rdbNo1),
                (rdbSi2, rdbNo2),
                (rdbSi3, rdbNo3),
                (rdbSi4, rdbNo4),
                (rdbSi5, rdbNo5),
                (rdbSi6, rdbNo6),
                (rdbSi7, rdbNo7),
                (rdbSi8, rdbNo8),
                (rdbSi9, rdbNo9)
            };

            for (int i = 0; i < preguntas.Length; i++)
            {
                if (!preguntas[i].si.Checked && !preguntas[i].no.Checked)
                {
                    MessageBox.Show($"Por favor, seleccione una opción para la pregunta {i + 1}.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int contarSi = 0;
            int contarNo = 0;
            foreach (var pregunta in preguntas)
            {
                if (pregunta.si.Checked) contarSi++;
                if (pregunta.no.Checked) contarNo++;

            }
            string estado = "";
            if(contarSi == 0)
            {
                estado= "ROBUSTO";
            }
            else if(contarSi == 1||contarSi== 2)
            {
                estado = "PRE-FRAGIL";
            }
            else if (contarSi >= 3)
            {
                estado = "FRAGIL";
            }



            MessageBox.Show("RESULTADO DEL TEST DE LINDA FRIED: \nTotal de respuestas de Si: " + contarSi + "\nTotal de respuestas de No: " + contarNo+ "\nEl resultado del Test es : " +estado);

        }

        private void btnVolverAlInicio_Click(object sender, EventArgs e)
        {
            InicioDeSesion inicioDeSesion = new InicioDeSesion();
            inicioDeSesion.ShowDialog();
            this.Hide();
        }
    }
}

