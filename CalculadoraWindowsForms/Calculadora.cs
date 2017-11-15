using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForms
{
    public partial class Calculadora : Form
    {
        double num1, num2, atual, resultado;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32("1");
            atual = num1;
            lblResultado.Text = atual.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {
         
        }
    }
}
