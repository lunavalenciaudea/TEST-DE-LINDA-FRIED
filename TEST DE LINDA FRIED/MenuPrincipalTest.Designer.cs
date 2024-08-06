namespace TEST_DE_LINDA_FRIED
{
    partial class MenuPrincipalTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.rdbRealizarTest = new System.Windows.Forms.RadioButton();
            this.rdbVolverInicio = new System.Windows.Forms.RadioButton();
            this.btnContinuarMenu = new System.Windows.Forms.Button();
            this.gpbGrupoMenuP = new System.Windows.Forms.GroupBox();
            this.gpbGrupoMenuP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Location = new System.Drawing.Point(367, 32);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(101, 13);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENÚ PRINCIPAL ";
            // 
            // rdbRealizarTest
            // 
            this.rdbRealizarTest.AutoSize = true;
            this.rdbRealizarTest.Location = new System.Drawing.Point(19, 48);
            this.rdbRealizarTest.Name = "rdbRealizarTest";
            this.rdbRealizarTest.Size = new System.Drawing.Size(197, 17);
            this.rdbRealizarTest.TabIndex = 1;
            this.rdbRealizarTest.TabStop = true;
            this.rdbRealizarTest.Text = "REALIZAR TEST DE LINDA FRIED";
            this.rdbRealizarTest.UseVisualStyleBackColor = true;
            // 
            // rdbVolverInicio
            // 
            this.rdbVolverInicio.AutoSize = true;
            this.rdbVolverInicio.Location = new System.Drawing.Point(19, 114);
            this.rdbVolverInicio.Name = "rdbVolverInicio";
            this.rdbVolverInicio.Size = new System.Drawing.Size(177, 17);
            this.rdbVolverInicio.TabIndex = 3;
            this.rdbVolverInicio.TabStop = true;
            this.rdbVolverInicio.Text = "VOLVER A INICIO DE SESION ";
            this.rdbVolverInicio.UseVisualStyleBackColor = true;
            // 
            // btnContinuarMenu
            // 
            this.btnContinuarMenu.Location = new System.Drawing.Point(381, 327);
            this.btnContinuarMenu.Name = "btnContinuarMenu";
            this.btnContinuarMenu.Size = new System.Drawing.Size(97, 27);
            this.btnContinuarMenu.TabIndex = 4;
            this.btnContinuarMenu.Text = "CONTINUAR";
            this.btnContinuarMenu.UseVisualStyleBackColor = true;
            this.btnContinuarMenu.Click += new System.EventHandler(this.btnContinuarMenu_Click);
            // 
            // gpbGrupoMenuP
            // 
            this.gpbGrupoMenuP.Controls.Add(this.rdbRealizarTest);
            this.gpbGrupoMenuP.Controls.Add(this.rdbVolverInicio);
            this.gpbGrupoMenuP.Location = new System.Drawing.Point(262, 107);
            this.gpbGrupoMenuP.Name = "gpbGrupoMenuP";
            this.gpbGrupoMenuP.Size = new System.Drawing.Size(299, 157);
            this.gpbGrupoMenuP.TabIndex = 5;
            this.gpbGrupoMenuP.TabStop = false;
            this.gpbGrupoMenuP.Text = "Elija una de las opciones ";
            // 
            // MenuPrincipalTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbGrupoMenuP);
            this.Controls.Add(this.btnContinuarMenu);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Name = "MenuPrincipalTest";
            this.Text = "MENÚ PRINCIPAL";
            this.gpbGrupoMenuP.ResumeLayout(false);
            this.gpbGrupoMenuP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuPrincipal;
        private System.Windows.Forms.RadioButton rdbRealizarTest;
        private System.Windows.Forms.RadioButton rdbVolverInicio;
        private System.Windows.Forms.Button btnContinuarMenu;
        private System.Windows.Forms.GroupBox gpbGrupoMenuP;
    }
}