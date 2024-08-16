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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormCalculadora().Show();
       
        }

        private void descontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormDesconto().Show();
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormIMC().Show();
        }
    }
}
