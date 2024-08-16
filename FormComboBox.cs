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
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEstado.SelectedIndex == 0)
            {
                cbCidade.Items.Clear();
                cbCidade.Items.Add("São Roque");
                cbCidade.Items.Add("Sorocaba");
            }
            else if(cbEstado.SelectedIndex == 1)
            {
                cbCidade.Items.Clear();
                cbCidade.Items.Add("Niterói");
                cbCidade.Items.Add("Cabo Frio");
            }
            else if (cbEstado.SelectedIndex == 2)
            {
                cbCidade.Items.Clear();
                cbCidade.Items.Add("Belo Horizonte");
                cbCidade.Items.Add("Ouro Preto");
            }
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estado escolhido: " + cbEstado.SelectedItem + ". Cidade escolhida: " + cbCidade.SelectedItem);
        }
    }
}
