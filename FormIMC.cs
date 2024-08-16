using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstruturaCondicional
{
    public partial class FormIMC : Form
    {
        double peso, altura, imc;

        public FormIMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            altura /= 100;
            imc = (peso / (altura * altura));
            imc = Math.Round(imc, 2);

            txtExibir.Text = imc.ToString();

            if (imc <= 16.9)
            {
                MessageBox.Show("Muito abaixo do peso", "IMC", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                MessageBox.Show("Abaixo do peso", "IMC", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                MessageBox.Show("Peso Normal", "IMC", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                MessageBox.Show("Acima do peso", "IMC", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else if (imc >= 30 & imc <= 34.9)
            {
                MessageBox.Show("Obesidade grau I", "IMC", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else if (imc >= 35 && imc <= 40)
            {
                MessageBox.Show("Obesidade grau II", "IMC", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Obesidade grau III", "IMC", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }


        }

    }
}
