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
    public partial class Practica2 : Form
    {
        public Practica2()
        {
            InitializeComponent();
        }

        private void Practicas2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bttnCalcular_Click(object sender, EventArgs e)
        {
 
            int NumVictorias = int.Parse(txtVictorias.Text);
            int NumEmpates = int.Parse(txtDerrotas.Text);

            int Pvictorias = NumVictorias * 3;
            int Pempate = NumEmpates * 1;

            int resultado = Pvictorias + Pempate;

            txtPuntos.Text = resultado.ToString();
        }

        private void bttnReset_Click(object sender, EventArgs e)
        {
            txtDerrotas.Clear();
            txtVictorias.Clear();
            txtPuntos.Clear();
        }
    }
}
