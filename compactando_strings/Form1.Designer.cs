﻿using System;

namespace compactando_strings
{
    partial class Form1
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
        /// the contents of this method with the code editor.        /// </summary>
        private void InitializeComponent()
        {
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtTextoCompactado = new System.Windows.Forms.TextBox();
            this.txtTextoDescompactado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(33, 30);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(329, 125);
            this.txtTexto.TabIndex = 0;
            // 
            // txtTextoCompactado
            // 
            this.txtTextoCompactado.Location = new System.Drawing.Point(33, 213);
            this.txtTextoCompactado.Multiline = true;
            this.txtTextoCompactado.Name = "txtTextoCompactado";
            this.txtTextoCompactado.Size = new System.Drawing.Size(329, 125);
            this.txtTextoCompactado.TabIndex = 1;
            // 
            // txtTextoDescompactado
            // 
            this.txtTextoDescompactado.Location = new System.Drawing.Point(33, 391);
            this.txtTextoDescompactado.Multiline = true;
            this.txtTextoDescompactado.Name = "txtTextoDescompactado";
            this.txtTextoDescompactado.Size = new System.Drawing.Size(329, 125);
            this.txtTextoDescompactado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Compactar string";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCompactaString_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Descompactar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDescompactaString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTextoDescompactado);
            this.Controls.Add(this.txtTextoCompactado);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtTextoCompactado;
        private System.Windows.Forms.TextBox txtTextoDescompactado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private readonly EventHandler Form1_Load;
    }
}

