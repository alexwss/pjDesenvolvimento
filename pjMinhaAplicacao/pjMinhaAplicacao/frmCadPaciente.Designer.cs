﻿namespace pjMinhaAplicacao
{
    partial class frmCadPaciente
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
            this.btnPesquisaPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPesquisaPaciente
            // 
            this.btnPesquisaPaciente.Location = new System.Drawing.Point(639, 48);
            this.btnPesquisaPaciente.Name = "btnPesquisaPaciente";
            this.btnPesquisaPaciente.Size = new System.Drawing.Size(133, 42);
            this.btnPesquisaPaciente.TabIndex = 0;
            this.btnPesquisaPaciente.Text = "Pesquisar";
            this.btnPesquisaPaciente.UseVisualStyleBackColor = true;
            this.btnPesquisaPaciente.Click += new System.EventHandler(this.btnPesquisaPaciente_Click);
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnPesquisaPaciente);
            this.Name = "frmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaPaciente;
    }
}