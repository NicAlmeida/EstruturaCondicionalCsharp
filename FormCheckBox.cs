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
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preco = 0;
            preco = double.Parse(txtPreco.Text);

            if (ckBorda.Checked && ckRefri.Checked)
            {
                preco += 16;
            }
            else if (ckBorda.Checked)
            {
                preco += 10;
            }
            else if(ckRefri.Checked)
            {
                preco += 6;
            }

            txtPrecoFinal.Text = preco.ToString("F");
        }
    }
}
