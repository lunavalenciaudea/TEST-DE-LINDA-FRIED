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
            this.listBoxRespuestas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxRespuestas
            // 
            this.listBoxRespuestas.FormattingEnabled = true;
            this.listBoxRespuestas.Location = new System.Drawing.Point(346, 114);
            this.listBoxRespuestas.Name = "listBoxRespuestas";
            this.listBoxRespuestas.Size = new System.Drawing.Size(120, 95);
            this.listBoxRespuestas.TabIndex = 0;
            // 
            // RespuestasTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxRespuestas);
            this.Name = "RespuestasTest";
            this.Text = "RespuestasTest";
            this.Load += new System.EventHandler(this.RespuestasTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRespuestas;

        public EventHandler RespuestasTest_Load { get; private set; }
    }
}