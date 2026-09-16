using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicas
{
    public partial class Practica1 : Form
    {
        public Practica1()
        {
            InitializeComponent();
        }

        private void  textHours_Text(object sender, EventArgs e)
        {
            
        }

        private void Practicas(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(WorkHour.Text);
            int PrecioH = int.Parse(PriceHour.Text);

            int resultado = horas * PrecioH;
            Total.Text = resultado.ToString();
        }
    }
}
