using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TEST_DE_LINDA_FRIED
{
    public partial class IngresoDeDatos : Form
    {
        public IngresoDeDatos()
        {
            InitializeComponent();
            EstilizarFormulario();
        }

        private void EstilizarFormulario()
        {
            // Fondo del formulario
            this.BackColor = System.Drawing.Color.FromArgb(249, 249, 249); // Blanco Hueso

            // Título (lblRegistroDeDatos)
            lblRegistroDeDatos.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistroDeDatos.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            // Labels
            EstilizarLabels();

            // Botón Guardar (btnContinuarRegistrodedatos)
            btnContinuarRegistrodedatos.FlatStyle = FlatStyle.Flat;
            btnContinuarRegistrodedatos.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro
            btnContinuarRegistrodedatos.ForeColor = System.Drawing.Color.White; // Texto blanco
            btnContinuarRegistrodedatos.FlatAppearance.BorderSize = 0;
            btnContinuarRegistrodedatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuarRegistrodedatos.MouseEnter += (s, e) => btnContinuarRegistrodedatos.BackColor = System.Drawing.Color.FromArgb(22, 160, 133); // Turquesa Oscuro al pasar el ratón
            btnContinuarRegistrodedatos.MouseLeave += (s, e) => btnContinuarRegistrodedatos.BackColor = System.Drawing.Color.FromArgb(26, 188, 156); // Turquesa Claro original

            // GroupBox (gbSexo)
            gbSexo.BackColor = System.Drawing.Color.FromArgb(234, 234, 234); // Gris Claro
            gbSexo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gbSexo.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro

            // Cajas de Texto
            EstilizarTextBoxes();
        }

        private void EstilizarLabels()
        {
            // Labels (lblPrimerNombre, lblPrimerApellido, lblSegundoApellido, lblNumeroDocumento, lblTipoDocumento, lblFechaNacimiento, lblSexo, lblDepartamentoResidencia, lblMunicipioResidencia, lblDireecciónResidencia)
            foreach (Control control in this.Controls)
            {
                if (control is Label label && label.Name.StartsWith("lbl"))
                {
                    label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point); // Negrita y más grande
                    label.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
                }
            }
        }

        private void EstilizarTextBoxes()
        {
            // Cajas de Texto (txtPrimerNombre, txtPrimerApellido, txtSegundoApellido, txtNumeroDocumento)
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox && textBox.Name.StartsWith("txt"))
                {
                    textBox.BackColor = System.Drawing.Color.White; // Blanco
                    textBox.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80); // Gris Oscuro
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        } 
        private void btnContinuarRegistrodedatos_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox[] requiredTextBoxes = { txtPirmerNombre, txtPrimerApellido, txtNumeroDocumento, txtDirecciónResidencia};

            bool allFieldsValid = true;
            foreach (var textBox in requiredTextBoxes)
            {
                
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    
                    textBox.BackColor = System.Drawing.Color.Pink; 
                    allFieldsValid = false;
                }
                else
                {
                    
                    textBox.BackColor = System.Drawing.Color.White; 
                }
            }

            if (!allFieldsValid)
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (ValidarDatos1())
            {
                MenuPrincipalTest menuPrincipalTest = new MenuPrincipalTest();
                menuPrincipalTest.Show();
                this.Hide();
            }
        }

        private bool ValidarDatos1()
        {
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
            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("por favor seleccione un Tipo de documento");
                return false;
            }
            if (!rdbFemenino.Checked && !rdbMaculino.Checked)
            {
                MessageBox.Show("Por favor, seleccione si el sexo es femenino o masculino.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtNumeroDocumento_TextChanged_1(object sender, EventArgs e)
        {
            string input = txtNumeroDocumento.Text;

            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^\d*$"))
            {
                string numericText = new string(input.Where(char.IsDigit).ToArray());
                MessageBox.Show("Por favor digite solo numeros");
                txtNumeroDocumento.Text = numericText;
                txtNumeroDocumento.SelectionStart = txtNumeroDocumento.Text.Length;
            }
        }
    }
}
