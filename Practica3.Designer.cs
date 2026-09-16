namespace Practicas
{
    partial class Practica3
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
            this.pTemperatura = new System.Windows.Forms.Label();
            this.pResultado = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.bttnCF = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.bttnLimpiar = new System.Windows.Forms.Button();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pTemperatura
            // 
            this.pTemperatura.AutoSize = true;
            this.pTemperatura.Location = new System.Drawing.Point(28, 39);
            this.pTemperatura.Name = "pTemperatura";
            this.pTemperatura.Size = new System.Drawing.Size(67, 13);
            this.pTemperatura.TabIndex = 0;
            this.pTemperatura.Text = "Temperatura";
            // 
            // pResultado
            // 
            this.pResultado.AutoSize = true;
            this.pResultado.Location = new System.Drawing.Point(38, 70);
            this.pResultado.Name = "pResultado";
            this.pResultado.Size = new System.Drawing.Size(55, 13);
            this.pResultado.TabIndex = 1;
            this.pResultado.Text = "Resultado";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(101, 36);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(101, 63);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // bttnCF
            // 
            this.bttnCF.Location = new System.Drawing.Point(31, 108);
            this.bttnCF.Name = "bttnCF";
            this.bttnCF.Size = new System.Drawing.Size(75, 23);
            this.bttnCF.TabIndex = 4;
            this.bttnCF.Text = "Fº";
            this.bttnCF.UseVisualStyleBackColor = true;
            this.bttnCF.Click += new System.EventHandler(this.bttnCF_Click);
            // 
            // bttnC
            // 
            this.bttnC.Location = new System.Drawing.Point(126, 108);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(75, 23);
            this.bttnC.TabIndex = 5;
            this.bttnC.Text = "Cº";
            this.bttnC.UseVisualStyleBackColor = true;
            this.bttnC.Click += new System.EventHandler(this.bttnC_Click);
            // 
            // bttnLimpiar
            // 
            this.bttnLimpiar.Location = new System.Drawing.Point(31, 225);
            this.bttnLimpiar.Name = "bttnLimpiar";
            this.bttnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.bttnLimpiar.TabIndex = 6;
            this.bttnLimpiar.Text = "Limpiar";
            this.bttnLimpiar.UseVisualStyleBackColor = true;
            this.bttnLimpiar.Click += new System.EventHandler(this.bttnLimpiar_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.Location = new System.Drawing.Point(126, 225);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(75, 23);
            this.bttnSalir.TabIndex = 7;
            this.bttnSalir.Text = "Salir";
            this.bttnSalir.UseVisualStyleBackColor = true;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // Practica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.bttnLimpiar);
            this.Controls.Add(this.bttnC);
            this.Controls.Add(this.bttnCF);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.pResultado);
            this.Controls.Add(this.pTemperatura);
            this.Name = "Practica3";
            this.Text = "Practica3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pTemperatura;
        private System.Windows.Forms.Label pResultado;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button bttnCF;
        private System.Windows.Forms.Button bttnC;
        private System.Windows.Forms.Button bttnLimpiar;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Label label3;
    }
}