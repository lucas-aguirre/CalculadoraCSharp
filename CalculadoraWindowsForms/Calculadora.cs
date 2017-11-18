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
        double num1 = 0, resultado = 0;
        int virgula = 0;
        string operacao;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "1";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "1";
                }
            }
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "2";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "2";
                }
            }
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "3";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "3";
                }
            }
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "4";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "4";
                }
            }
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "5";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "5";
                }
            }
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "6";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "6";
                }
            }
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "7";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "7";
                }
            }
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "8";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "8";
                }
            }
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "9";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "9";
                }
            }
        }

        private void bntZero_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text == "0")
            {
                txtBoxResult.Text = "0";
            }
            else
            {
                if (txtBoxResult.Text.Length < 10)
                {
                    txtBoxResult.Text += "0";
                }
            }
        }
        
        //Condição para virgula com contador, caso for 0 insere a virgula, caso contrário não insere e impede o usuário inserir várias virgulas
        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (virgula == 0)
            {
                txtBoxResult.Text += ",";
                virgula = 1;
            }
        }

        //Condição de soma
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text != "")
            {
                num1 = double.Parse(txtBoxResult.Text);
                txtBoxResult.Text = "";
                operacao = "+";
                virgula = 0;
            }
        }

        //Condição de subtração
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text != "")
            {
                num1 = double.Parse(txtBoxResult.Text);
                txtBoxResult.Text = "";
                operacao = "-";
                virgula = 0;
            }
        }

        //Condição de divisão
        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text != "")
            {
                num1 = double.Parse(txtBoxResult.Text);
                txtBoxResult.Text = "";
                operacao = "/";
                virgula = 0;
            }
        }

        //Condição de multiplicação
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (txtBoxResult.Text != "")
            {
                num1 = double.Parse(txtBoxResult.Text);
                txtBoxResult.Text = "";
                operacao = "*";
                virgula = 0;
            }
        }

        //Condição do igual para realizar o cálculo final
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                //Condição que estava bugando
                if (txtBoxResult.Text == "")
                {

                }else
                {
                    resultado = num1 + double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = resultado.ToString();
                }
            }
            if (operacao == "-")
            {
                //Condição que estava bugando
                if (txtBoxResult.Text == "")
                {

                }
                else
                {
                    resultado = num1 - double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = resultado.ToString();
                }
            }
            if (operacao == "/")
            {
                //Condição que estava bugando
                if (txtBoxResult.Text == "")
                {

                }
                else
                {
                    resultado = num1 / double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = resultado.ToString();
                }
            }
            if (operacao == "*")
            {//Condição que estava bugando
                if (txtBoxResult.Text == "")
                {

                }
                else
                {
                    resultado = num1 * double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = resultado.ToString();
                }
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        //Condição de clear para limpar tudo
        private void btnClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            resultado = 0;
            virgula = 0;
            txtBoxResult.Text = num1.ToString();
        }

        //Condição de apagar o que o usuário digitou sem apagar o número ou soma anterior
        private void btnCancelEntry_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int x;

            if (txtBoxResult.Text.Length > 1)
            {
                txtBoxResult.Text = txtBoxResult.Text.Remove(txtBoxResult.Text.Length - 1);
            }
            else
            {
                txtBoxResult.Text = "0";
            }
        }
        
        //KeyDown do text bot p/ inserir dados pelo teclado
        private void txtBoxResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "0";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "0";
                    }
                }
            }
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "1";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "1";
                    }
                }
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "2";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "2";
                    }
                }
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "3";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "3";
                    }
                }
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "4";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "4";
                    }
                }
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "5";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "5";
                    }
                }
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "6";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "6";
                    }
                }
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "7";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "7";
                    }
                }
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "8";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "8";
                    }
                }
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                if (txtBoxResult.Text == "0")
                {
                    txtBoxResult.Text = "9";
                }
                else
                {
                    if (txtBoxResult.Text.Length < 10)
                    {
                        txtBoxResult.Text += "9";
                    }
                }
            }
            if (e.KeyCode == Keys.Add)
            {
                if (txtBoxResult.Text != "")
                {
                    num1 = double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = "";
                    operacao = "+";
                    virgula = 0;
                }
            }
            if (e.KeyCode == Keys.Subtract)
            {
                if (txtBoxResult.Text != "")
                {
                    num1 = double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = "";
                    operacao = "-";
                    virgula = 0;
                }
            }
            if (e.KeyCode == Keys.Divide)
            {
                if (txtBoxResult.Text != "")
                {
                    num1 = double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = "";
                    operacao = "/";
                    virgula = 0;
                }
            }
            if (e.KeyCode == Keys.Multiply)
            {
                if (txtBoxResult.Text != "")
                {
                    num1 = double.Parse(txtBoxResult.Text);
                    txtBoxResult.Text = "";
                    operacao = "*";
                    virgula = 0;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (operacao == "+")
                {
                    //Condição que estava bugando
                    if (txtBoxResult.Text == "")
                    {

                    }
                    else
                    {
                        resultado = num1 + double.Parse(txtBoxResult.Text);
                        txtBoxResult.Text = resultado.ToString();
                    }
                }
                if (operacao == "-")
                {
                    //Condição que estava bugando
                    if (txtBoxResult.Text == "")
                    {

                    }
                    else
                    {
                        resultado = num1 - double.Parse(txtBoxResult.Text);
                        txtBoxResult.Text = resultado.ToString();
                    }
                }
                if (operacao == "/")
                {
                    //Condição que estava bugando
                    if (txtBoxResult.Text == "")
                    {

                    }
                    else
                    {
                        resultado = num1 / double.Parse(txtBoxResult.Text);
                        txtBoxResult.Text = resultado.ToString();
                    }
                }
                if (operacao == "*")
                {
                    //Condição que estava bugando
                    if (txtBoxResult.Text == "")
                    {

                    }
                    else
                    {
                        resultado = num1 * double.Parse(txtBoxResult.Text);
                        txtBoxResult.Text = resultado.ToString();
                    }
                }
            }
            if (e.KeyCode == Keys.Back)
            {
                int x;

            //Condição para apagar, caso tenha mais de 1 caractere ele apaga, caso for o último substitui por 0
            if (txtBoxResult.Text.Length > 1)
            {
                txtBoxResult.Text = txtBoxResult.Text.Remove(txtBoxResult.Text.Length - 1);
            }
            else
            {
                txtBoxResult.Text = "0";
            }
            }
        }
    }
}
