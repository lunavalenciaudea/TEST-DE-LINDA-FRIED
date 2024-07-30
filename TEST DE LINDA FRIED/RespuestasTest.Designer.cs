using System;

namespace TEST_DE_LINDA_FRIED
{
    partial class RespuestasTest
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
            this.lvlResultado = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblTituloRespuestas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvlResultado
            // 
            this.lvlResultado.AutoSize = true;
            this.lvlResultado.Location = new System.Drawing.Point(220, 121);
            this.lvlResultado.Name = "lvlResultado";
            this.lvlResultado.Size = new System.Drawing.Size(0, 13);
            this.lvlResultado.TabIndex = 0;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(400, 134);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(35, 13);
            this.lblResultados.TabIndex = 1;
            this.lblResultados.Text = "label1";
            // 
            // lblTituloRespuestas
            // 
            this.lblTituloRespuestas.AutoSize = true;
            this.lblTituloRespuestas.Location = new System.Drawing.Point(310, 33);
            this.lblTituloRespuestas.Name = "lblTituloRespuestas";
            this.lblTituloRespuestas.Size = new System.Drawing.Size(192, 13);
            this.lblTituloRespuestas.TabIndex = 2;
            this.lblTituloRespuestas.Text = "RESULTADO TEST DE LINDA FRIED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "El resultado de su test es :";
            // 
            // btnSalirResultado
            // 
            this.btnSalirResultado.Location = new System.Drawing.Point(379, 228);
            this.btnSalirResultado.Name = "btnSalirResultado";
            this.btnSalirResultado.Size = new System.Drawing.Size(75, 23);
            this.btnSalirResultado.TabIndex = 4;
            this.btnSalirResultado.Text = "SALIR";
            this.btnSalirResultado.UseVisualStyleBackColor = true;
            this.btnSalirResultado.Click += new System.EventHandler(this.btnSalirResultado_Click);
            // 
            // RespuestasTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloRespuestas);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lvlResultado);
            this.Name = "RespuestasTest";
            this.Text = "RespuestasTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvlResultado;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblTituloRespuestas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirResultado;

        public EventHandler RespuestasTest_Load { get; private set; }
    }
}