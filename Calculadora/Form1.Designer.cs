﻿namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.botons = new System.Windows.Forms.Button();
            this.botonr = new System.Windows.Forms.Button();
            this.botonm = new System.Windows.Forms.Button();
            this.botond = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rpta = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(77, 51);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(100, 20);
            this.n1.TabIndex = 0;
            this.n1.TextChanged += new System.EventHandler(this.n1_TextChanged);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(77, 110);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(100, 20);
            this.n2.TabIndex = 1;
            // 
            // botons
            // 
            this.botons.BackColor = System.Drawing.Color.Blue;
            this.botons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botons.ForeColor = System.Drawing.Color.Snow;
            this.botons.Location = new System.Drawing.Point(197, 35);
            this.botons.Name = "botons";
            this.botons.Size = new System.Drawing.Size(50, 36);
            this.botons.TabIndex = 2;
            this.botons.Text = "+";
            this.botons.UseVisualStyleBackColor = false;
            this.botons.Click += new System.EventHandler(this.botons_Click);
            // 
            // botonr
            // 
            this.botonr.BackColor = System.Drawing.Color.Blue;
            this.botonr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonr.ForeColor = System.Drawing.Color.Snow;
            this.botonr.Location = new System.Drawing.Point(197, 77);
            this.botonr.Name = "botonr";
            this.botonr.Size = new System.Drawing.Size(50, 31);
            this.botonr.TabIndex = 3;
            this.botonr.Text = "-";
            this.botonr.UseVisualStyleBackColor = false;
            this.botonr.Click += new System.EventHandler(this.botonr_Click);
            // 
            // botonm
            // 
            this.botonm.BackColor = System.Drawing.Color.Blue;
            this.botonm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonm.ForeColor = System.Drawing.Color.Snow;
            this.botonm.Location = new System.Drawing.Point(197, 114);
            this.botonm.Name = "botonm";
            this.botonm.Size = new System.Drawing.Size(50, 31);
            this.botonm.TabIndex = 4;
            this.botonm.Text = "*";
            this.botonm.UseVisualStyleBackColor = false;
            this.botonm.Click += new System.EventHandler(this.botonm_Click);
            // 
            // botond
            // 
            this.botond.BackColor = System.Drawing.Color.Blue;
            this.botond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botond.ForeColor = System.Drawing.Color.Snow;
            this.botond.Location = new System.Drawing.Point(197, 151);
            this.botond.Name = "botond";
            this.botond.Size = new System.Drawing.Size(50, 33);
            this.botond.TabIndex = 5;
            this.botond.Text = "/";
            this.botond.UseVisualStyleBackColor = false;
            this.botond.Click += new System.EventHandler(this.botond_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(13, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Respuesta";
            // 
            // rpta
            // 
            this.rpta.AutoSize = true;
            this.rpta.BackColor = System.Drawing.Color.Red;
            this.rpta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpta.ForeColor = System.Drawing.Color.Snow;
            this.rpta.Location = new System.Drawing.Point(92, 161);
            this.rpta.Name = "rpta";
            this.rpta.Size = new System.Drawing.Size(0, 24);
            this.rpta.TabIndex = 9;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(36, 192);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(0, 13);
            this.warning.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.rpta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botond);
            this.Controls.Add(this.botonm);
            this.Controls.Add(this.botonr);
            this.Controls.Add(this.botons);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Calculadora1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Button botons;
        private System.Windows.Forms.Button botonr;
        private System.Windows.Forms.Button botonm;
        private System.Windows.Forms.Button botond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rpta;
        private System.Windows.Forms.Label warning;
    }
}

