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
    public partial class FormRadioButton : Form
    {
        public FormRadioButton()
        {
            InitializeComponent();
        }

        private void btnEscollher_Click(object sender, EventArgs e)
        {
            if(rbJava.Checked)
            {
                txtResposta.Text = "Java";
            }
            else if(rbCsharp.Checked) 
            {
                txtResposta.Text = "C#";
            }
            else if (rbPHP.Checked)
            {
                txtResposta.Text = "PHP";
            }
        }
    }
}
