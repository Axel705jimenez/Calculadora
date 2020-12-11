  
using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }


        private void MiMetodo_Click(object sender, EventArgs e)
        {
            string textoBoton = ((Button)sender).Text;
            switch (textoBoton)
            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoR = Math.Sqrt(valor1);
                    lblNumeros.Text = resultadoR +"";
                    break;
                case "ln":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoln = Math.Log (valor1);
                    lblNumeros.Text = resultadoln+"";
                    break;
                case "Log10":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoLog10 = Math.Log10(valor1);
                    lblNumeros.Text = resultadoLog10 + "";
                    break;
                 case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoTan = Math.Tan(valor1);
                    lblNumeros.Text = resultadoTan + "";
                    break;
                 case "Sin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoSin = Math.Sin(valor1);
                    lblNumeros.Text = resultadoSin + "";
                    break;
                 case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoCos = Math.Cos(valor1);
                    lblNumeros.Text = resultadoCos + "";
                    break;
                case "+":
                if (lblNumeros.Text == "")
                {
                        break;
                }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "-":
                   if (lblNumeros.Text == "")
                {
                        break;
                }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = ""; 
                    break;
                case "X":
                   if (lblNumeros.Text == "")
                {
                        break;
                }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "/":
                   if (lblNumeros.Text == "")
                {
                        break;
                }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "=":
                    switch (operacion)
                    {
                        case "+":
                           if (lblNumeros.Text == "")
                             {
                                break;
                             }
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 + valor2) + "";
                            break;
                        case "-":
                           if (lblNumeros.Text == "")
                           {
                                break;
                           }
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 - valor2) + "";
                            break;
                        case "X":
                           if (lblNumeros.Text == "")
                           {
                                break;
                           }
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 * valor2) + "";
                            break;
                        case "/":
                           if (lblNumeros.Text == "")
                           {
                                break;
                           }
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 / valor2) + "";
                            break;
                    }
                break;
                case "AC":
                    lblNumeros.Text = "";
                    break;
                    case ".":
                    if (lblNumeros.Text.IndexOf(".") == -1)
                    {
                     lblNumeros.Text += textoBoton;
                    }
                    break;
                default:
                    lblNumeros.Text += textoBoton;
                break;
            }
        }
    }
}
