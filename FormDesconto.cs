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
    public partial class FormDesconto : Form
    {
        public FormDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string produto;
            double precoUnitario, totalSemDesconto, totalComDesconto, desconto=0;
            int qtd;

            produto = txtProduto.Text;
            precoUnitario = double.Parse(txtPreco.Text);
            qtd = int.Parse(txtQtd.Text);

            totalSemDesconto = precoUnitario * qtd;

            if (qtd >= 5)
            {
                desconto = totalSemDesconto * 0.02;

            }
            else if (qtd > 5 && qtd <= 10)
            {
                desconto = totalSemDesconto * 0.03;
            }
            else if( qtd > 10)
            {
                desconto = totalSemDesconto * 0.05;


            }

            totalComDesconto = totalSemDesconto - desconto;

            txtDesc.Text = desconto.ToString();
            txtTotal.Text = totalSemDesconto.ToString();
            txtTd.Text = totalComDesconto.ToString();
           


        }
    }
}
