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
    public partial class FormQuestionario : Form
    {
        public FormQuestionario()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (rbRock.Checked)
            {
                txtResposta.Text = ("Rock");
            }
            else if(rbPop.Checked)
            {
                txtResposta.Text = ("Pop");
            }
            else if (rbMPB.Checked)
            {
                txtResposta.Text = ("MPB");
            }
            else if (rbEletro.Checked)
            {
                txtResposta.Text = ("Eletronica");
            }
            else if (rbRap.Checked)
            {
                txtResposta.Text = ("Rap");
            }
            else if (rbTrap.Checked)
            {
                txtResposta.Text = ("Trap");
            }
            else if (rbIndie.Checked)
            {
                txtResposta.Text = ("Indie");
            }
            else if (rbPagode.Checked)
            {
                txtResposta.Text = ("Pagode");
            }
            else if (rbSamba.Checked)
            {
                txtResposta.Text = ("Samba");
            }
            else if (rbMetal.Checked)
            {
                txtResposta.Text = ("Metal");
            }
        }
    }
}
