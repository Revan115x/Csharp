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
    public partial class Practica3 : Form
    {
        public Practica3()
        {
            InitializeComponent();
        }

        private void bttnCF_Click(object sender, EventArgs e)
        {
            double Fahrenheit=double.Parse(txtTemperatura.Text);

            double resultado = (Fahrenheit - 32) * 5 / 9;

            txtResultado.Text = resultado.ToString();

        }

        private void bttnC_Click(object sender, EventArgs e)
        {
            double Celsius = double.Parse(txtTemperatura.Text);
            double resultado = ((Celsius * 9) / 5) + 32;

            txtResultado.Text = resultado.ToString();
        }

        private void bttnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtTemperatura.Clear();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
