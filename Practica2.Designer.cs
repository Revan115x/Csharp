namespace Practicas
{
    partial class Practica2
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
            this.Victorias = new System.Windows.Forms.Label();
            this.txtVictorias = new System.Windows.Forms.TextBox();
            this.txtDerrotas = new System.Windows.Forms.TextBox();
            this.Derrotas = new System.Windows.Forms.Label();
            this.Puntos = new System.Windows.Forms.Label();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Victorias
            // 
            this.Victorias.AutoSize = true;
            this.Victorias.Location = new System.Drawing.Point(19, 46);
            this.Victorias.Name = "Victorias";
            this.Victorias.Size = new System.Drawing.Size(47, 13);
            this.Victorias.TabIndex = 3;
            this.Victorias.Text = "Victorias";
            // 
            // txtVictorias
            // 
            this.txtVictorias.Location = new System.Drawing.Point(72, 42);
            this.txtVictorias.Name = "txtVictorias";
            this.txtVictorias.Size = new System.Drawing.Size(100, 20);
            this.txtVictorias.TabIndex = 4;
            // 
            // txtDerrotas
            // 
            this.txtDerrotas.Location = new System.Drawing.Point(72, 76);
            this.txtDerrotas.Name = "txtDerrotas";
            this.txtDerrotas.Size = new System.Drawing.Size(100, 20);
            this.txtDerrotas.TabIndex = 5;
            // 
            // Derrotas
            // 
            this.Derrotas.AutoSize = true;
            this.Derrotas.Location = new System.Drawing.Point(19, 80);
            this.Derrotas.Name = "Derrotas";
            this.Derrotas.Size = new System.Drawing.Size(47, 13);
            this.Derrotas.TabIndex = 6;
            this.Derrotas.Text = "Derrotas";
            this.Derrotas.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.Location = new System.Drawing.Point(78, 166);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(40, 13);
            this.Puntos.TabIndex = 7;
            this.Puntos.Text = "Puntos";
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(22, 182);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(150, 20);
            this.txtPuntos.TabIndex = 8;
            this.txtPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(22, 124);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 23);
            this.bttnCalcular.TabIndex = 9;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(103, 124);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(75, 23);
            this.bttnReset.TabIndex = 10;
            this.bttnReset.Text = "limpiar";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // Practicas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 255);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.txtPuntos);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.Derrotas);
            this.Controls.Add(this.txtDerrotas);
            this.Controls.Add(this.txtVictorias);
            this.Controls.Add(this.Victorias);
            this.Name = "Practicas2";
            this.Text = "Practicas2";
            this.Load += new System.EventHandler(this.Practicas2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Victorias;
        private System.Windows.Forms.TextBox txtVictorias;
        private System.Windows.Forms.TextBox txtDerrotas;
        private System.Windows.Forms.Label Derrotas;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnReset;
    }
}