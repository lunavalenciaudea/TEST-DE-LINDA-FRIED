using System;
using System.Windows.Forms;

namespace TEST_DE_LINDA_FRIED
{
    partial class IngresoDeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       
        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMaculino = new System.Windows.Forms.RadioButton();
            this.lblRegistroDeDatos = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblDepartamentoResidencia = new System.Windows.Forms.Label();
            this.lblDireecciónResidencia = new System.Windows.Forms.Label();
            this.lblMunicipioResidencia = new System.Windows.Forms.Label();
            this.txtPirmerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.txtDirecciónResidencia = new System.Windows.Forms.TextBox();
            this.btnContinuarRegistrodedatos = new System.Windows.Forms.Button();
            this.cboDepartamentoResidencia = new System.Windows.Forms.ComboBox();
            this.cboMunicipioDeResidencia = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.gbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(433, 137);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo";
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 19);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMaculino
            // 
            this.rdbMaculino.AutoSize = true;
            this.rdbMaculino.Location = new System.Drawing.Point(109, 19);
            this.rdbMaculino.Name = "rdbMaculino";
            this.rdbMaculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMaculino.TabIndex = 2;
            this.rdbMaculino.TabStop = true;
            this.rdbMaculino.Text = "Masculino";
            this.rdbMaculino.UseVisualStyleBackColor = true;
            // 
            // lblRegistroDeDatos
            // 
            this.lblRegistroDeDatos.AutoSize = true;
            this.lblRegistroDeDatos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroDeDatos.Location = new System.Drawing.Point(421, 21);
            this.lblRegistroDeDatos.Name = "lblRegistroDeDatos";
            this.lblRegistroDeDatos.Size = new System.Drawing.Size(200, 15);
            this.lblRegistroDeDatos.TabIndex = 3;
            this.lblRegistroDeDatos.Text = "Registro De Datos Personales";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Location = new System.Drawing.Point(50, 81);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(76, 13);
            this.lblPrimerNombre.TabIndex = 4;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Location = new System.Drawing.Point(50, 133);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNombre.TabIndex = 5;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(50, 183);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(76, 13);
            this.lblPrimerApellido.TabIndex = 6;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(50, 235);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoApellido.TabIndex = 7;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(50, 284);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(102, 13);
            this.lblNumeroDocumento.TabIndex = 8;
            this.lblNumeroDocumento.Text = "Numero Documento";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(50, 344);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDocumento.TabIndex = 9;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(433, 81);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 10;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblDepartamentoResidencia
            // 
            this.lblDepartamentoResidencia.AutoSize = true;
            this.lblDepartamentoResidencia.Location = new System.Drawing.Point(433, 192);
            this.lblDepartamentoResidencia.Name = "lblDepartamentoResidencia";
            this.lblDepartamentoResidencia.Size = new System.Drawing.Size(148, 13);
            this.lblDepartamentoResidencia.TabIndex = 11;
            this.lblDepartamentoResidencia.Text = "Departamento de Residencia ";
            // 
            // lblDireecciónResidencia
            // 
            this.lblDireecciónResidencia.AutoSize = true;
            this.lblDireecciónResidencia.Location = new System.Drawing.Point(433, 284);
            this.lblDireecciónResidencia.Name = "lblDireecciónResidencia";
            this.lblDireecciónResidencia.Size = new System.Drawing.Size(123, 13);
            this.lblDireecciónResidencia.TabIndex = 12;
            this.lblDireecciónResidencia.Text = "Dirección de Residencia";
            // 
            // lblMunicipioResidencia
            // 
            this.lblMunicipioResidencia.AutoSize = true;
            this.lblMunicipioResidencia.Location = new System.Drawing.Point(433, 234);
            this.lblMunicipioResidencia.Name = "lblMunicipioResidencia";
            this.lblMunicipioResidencia.Size = new System.Drawing.Size(123, 13);
            this.lblMunicipioResidencia.TabIndex = 13;
            this.lblMunicipioResidencia.Text = "Municipio de Residencia";
            // 
            // txtPirmerNombre
            // 
            this.txtPirmerNombre.Location = new System.Drawing.Point(228, 78);
            this.txtPirmerNombre.MaxLength = 20;
            this.txtPirmerNombre.Name = "txtPirmerNombre";
            this.txtPirmerNombre.Size = new System.Drawing.Size(144, 20);
            this.txtPirmerNombre.TabIndex = 14;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(228, 130);
            this.txtSegundoNombre.MaxLength = 20;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(144, 20);
            this.txtSegundoNombre.TabIndex = 15;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(228, 175);
            this.txtPrimerApellido.MaxLength = 20;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(144, 20);
            this.txtPrimerApellido.TabIndex = 16;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(228, 227);
            this.txtSegundoApellido.MaxLength = 20;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(144, 20);
            this.txtSegundoApellido.TabIndex = 17;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(228, 276);
            this.txtNumeroDocumento.MaxLength = 12;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(144, 20);
            this.txtNumeroDocumento.TabIndex = 18;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged_1);
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Cedula de Ciudadania",
            "Tarjeta de Identidad",
            "Cedula de Extranjeria"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(228, 344);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(144, 21);
            this.cboTipoDocumento.TabIndex = 19;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(664, 81);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 20;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 5, 14, 7, 36, 4, 0);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdbFemenino);
            this.gbSexo.Controls.Add(this.rdbMaculino);
            this.gbSexo.Location = new System.Drawing.Point(664, 120);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 46);
            this.gbSexo.TabIndex = 21;
            this.gbSexo.TabStop = false;
            // 
            // txtDirecciónResidencia
            // 
            this.txtDirecciónResidencia.Location = new System.Drawing.Point(664, 278);
            this.txtDirecciónResidencia.MaxLength = 100;
            this.txtDirecciónResidencia.Name = "txtDirecciónResidencia";
            this.txtDirecciónResidencia.Size = new System.Drawing.Size(153, 20);
            this.txtDirecciónResidencia.TabIndex = 24;
            // 
            // btnContinuarRegistrodedatos
            // 
            this.btnContinuarRegistrodedatos.Location = new System.Drawing.Point(505, 397);
            this.btnContinuarRegistrodedatos.Name = "btnContinuarRegistrodedatos";
            this.btnContinuarRegistrodedatos.Size = new System.Drawing.Size(91, 30);
            this.btnContinuarRegistrodedatos.TabIndex = 25;
            this.btnContinuarRegistrodedatos.Text = "CONTINUAR";
            this.btnContinuarRegistrodedatos.UseVisualStyleBackColor = true;
            this.btnContinuarRegistrodedatos.Click += new System.EventHandler(this.btnContinuarRegistrodedatos_Click);
            // 
            // cboDepartamentoResidencia
            // 
            this.cboDepartamentoResidencia.FormattingEnabled = true;
            this.cboDepartamentoResidencia.Items.AddRange(new object[] {
            "Antioquía",
            "Chocó",
            "La Guajira",
            "Magdalena",
            "Risaralda",
            "Tolima",
            "Valle del Cauca"});
            this.cboDepartamentoResidencia.Location = new System.Drawing.Point(664, 184);
            this.cboDepartamentoResidencia.Name = "cboDepartamentoResidencia";
            this.cboDepartamentoResidencia.Size = new System.Drawing.Size(121, 21);
            this.cboDepartamentoResidencia.TabIndex = 26;
            // 
            // cboMunicipioDeResidencia
            // 
            this.cboMunicipioDeResidencia.FormattingEnabled = true;
            this.cboMunicipioDeResidencia.Items.AddRange(new object[] {
            "Cali",
            "Medellin",
            "Itagui",
            "Pereira Santuario",
            "Santa Marta",
            "Ibague"});
            this.cboMunicipioDeResidencia.Location = new System.Drawing.Point(664, 232);
            this.cboMunicipioDeResidencia.Name = "cboMunicipioDeResidencia";
            this.cboMunicipioDeResidencia.Size = new System.Drawing.Size(121, 21);
            this.cboMunicipioDeResidencia.TabIndex = 27;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(378, 78);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(11, 13);
            this.lbl1.TabIndex = 29;
            this.lbl1.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(378, 175);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(11, 13);
            this.lbl2.TabIndex = 30;
            this.lbl2.Text = "*";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(378, 276);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(11, 13);
            this.lbl3.TabIndex = 31;
            this.lbl3.Text = "*";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl4.ForeColor = System.Drawing.Color.Red;
            this.lbl4.Location = new System.Drawing.Point(378, 344);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(11, 13);
            this.lbl4.TabIndex = 32;
            this.lbl4.Text = "*";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl5.Location = new System.Drawing.Point(870, 80);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(11, 13);
            this.lbl5.TabIndex = 33;
            this.lbl5.Text = "*";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl6.ForeColor = System.Drawing.Color.Red;
            this.lbl6.Location = new System.Drawing.Point(870, 130);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(11, 13);
            this.lbl6.TabIndex = 34;
            this.lbl6.Text = "*";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl7.ForeColor = System.Drawing.Color.Red;
            this.lbl7.Location = new System.Drawing.Point(791, 180);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(11, 13);
            this.lbl7.TabIndex = 35;
            this.lbl7.Text = "*";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl8.ForeColor = System.Drawing.Color.Red;
            this.lbl8.Location = new System.Drawing.Point(791, 229);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(11, 13);
            this.lbl8.TabIndex = 36;
            this.lbl8.Text = "*";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.SystemColors.Menu;
            this.lbl9.ForeColor = System.Drawing.Color.Red;
            this.lbl9.Location = new System.Drawing.Point(823, 278);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(11, 13);
            this.lbl9.TabIndex = 37;
            this.lbl9.Text = "*";
            // 
            // IngresoDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cboMunicipioDeResidencia);
            this.Controls.Add(this.cboDepartamentoResidencia);
            this.Controls.Add(this.btnContinuarRegistrodedatos);
            this.Controls.Add(this.txtDirecciónResidencia);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPirmerNombre);
            this.Controls.Add(this.lblMunicipioResidencia);
            this.Controls.Add(this.lblDireecciónResidencia);
            this.Controls.Add(this.lblDepartamentoResidencia);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTipoDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.lblRegistroDeDatos);
            this.Controls.Add(this.lblSexo);
            this.Name = "IngresoDeDatos";
            this.Text = "Registro Datos";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMaculino;
        private System.Windows.Forms.Label lblRegistroDeDatos;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblDepartamentoResidencia;
        private System.Windows.Forms.Label lblDireecciónResidencia;
        private System.Windows.Forms.Label lblMunicipioResidencia;
        private System.Windows.Forms.TextBox txtPirmerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.TextBox txtDirecciónResidencia;
        private System.Windows.Forms.Button btnContinuarRegistrodedatos;
        private ComboBox cboDepartamentoResidencia;
        private ComboBox cboMunicipioDeResidencia;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
        private Label lbl8;
        private Label lbl9;
    }

}

