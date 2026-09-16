namespace Practicas
{
    partial class Practica1
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
            this.Calcular = new System.Windows.Forms.Button();
            this.Thoras = new System.Windows.Forms.Label();
            this.Shoras = new System.Windows.Forms.Label();
            this.PriceHour = new System.Windows.Forms.TextBox();
            this.WorkHour = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(233, 40);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Thoras
            // 
            this.Thoras.AutoSize = true;
            this.Thoras.Location = new System.Drawing.Point(12, 26);
            this.Thoras.Name = "Thoras";
            this.Thoras.Size = new System.Drawing.Size(91, 13);
            this.Thoras.TabIndex = 1;
            this.Thoras.Text = "Horas Trabajadas";
            // 
            // Shoras
            // 
            this.Shoras.AutoSize = true;
            this.Shoras.Location = new System.Drawing.Point(147, 26);
            this.Shoras.Name = "Shoras";
            this.Shoras.Size = new System.Drawing.Size(65, 13);
            this.Shoras.TabIndex = 2;
            this.Shoras.Text = "Salario Hora";
            // 
            // PriceHour
            // 
            this.PriceHour.Location = new System.Drawing.Point(127, 42);
            this.PriceHour.Name = "PriceHour";
            this.PriceHour.Size = new System.Drawing.Size(100, 20);
            this.PriceHour.TabIndex = 3;
            // 
            // WorkHour
            // 
            this.WorkHour.Location = new System.Drawing.Point(7, 42);
            this.WorkHour.Name = "WorkHour";
            this.WorkHour.Size = new System.Drawing.Size(100, 20);
            this.WorkHour.TabIndex = 4;
          
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(7, 85);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(220, 20);
            this.Total.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 129);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.WorkHour);
            this.Controls.Add(this.PriceHour);
            this.Controls.Add(this.Shoras);
            this.Controls.Add(this.Thoras);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Thoras;
        private System.Windows.Forms.Label Shoras;
        private System.Windows.Forms.TextBox PriceHour;
        private System.Windows.Forms.TextBox WorkHour;
        private System.Windows.Forms.TextBox Total;
    }
}

