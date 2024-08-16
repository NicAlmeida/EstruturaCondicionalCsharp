using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstruturaCondicional
{
    public partial class FormCalculadora : Form
    {
        double n1, n2, soma, subtracao, multiplicacao, divisao, resultado;
        string operacao;

        public FormCalculadora()
        {
            InitializeComponent();
        }

      
        public void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operacao = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacao = "*";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operacao = "/";
        
        }
        
  

        private void btnCalcular_Click(object sender, EventArgs e)
        {

             n1 = Convert.ToDouble(txtValor1.Text);
             n2 = Convert.ToDouble(txtValor2.Text);


            if (operacao == "+")
            {
                soma = n1 + n2;
                resultado = soma;

            }
            else if (operacao == "-") 
            {
                subtracao = n1 - n2;
                resultado = subtracao;
            }
            else if (operacao == "*")
            {
                multiplicacao = n1 * n2;
                resultado = multiplicacao;
            }
            else
            {
                divisao = n1 / n2;
                resultado = divisao;
            }
 

            txtResultado.Text = resultado.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtResultado.Clear();
            operacao = string.Empty;    
        }
    }
}
