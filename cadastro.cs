using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class cadastro : Form
    {

        public cadastro()
        {//iniciando formulario atual e passando a informaçao que dialog result é cancel para fechar form antigo
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void cadastro_Load(object sender, EventArgs e)
        {//Definindo o foco para Label nome 
            lblNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {//Definindo resultado do dialogo como "OK" para fechar form
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {//Fechando o form quando clicado no botão
            this.Close();
        }

        private void txtObservacao_Enter(object sender, EventArgs e)
        {//Definindo label obs como visivel
            lblObs.Visible = true;
        }

        private void txtObservacao_Leave(object sender, EventArgs e)
        {//Definindo se label obs vai ser visivel ou nao se estiver vazio ou nao 
            lblObs.Visible = (txtObservacao.Text.Trim() != "");
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {//Definindo se label Nome vai ser visivel ou nao se estiver vazio ou nao
            lblNome.Visible = (txtNome.Text.Trim() != "");
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {//Definindo label nome como visivel
            lblNome.Visible = true;
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {//Definindo se label Qtd vai ser visivel ou nao se estiver vazio ou nao
            lblQtd.Visible = (txtQtd.Text.Trim() != "");
        }

        private void txtQtd_Enter(object sender, EventArgs e)
        {//Definindo label Qtd como visivel
            lblQtd.Visible = true;
        }
    }
}
