using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {//passando as informaçoes constantes para login e checkando 
            if (txtEmail.Text == "admin@carnenobre.com.br" && txtSenha.Text == "admin")
            {//Se as informações forem corretas o form de login sera fechado e login sera efetuado
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {//Se nao, aparecera uma caixa de dialogo informado o erro 
                MessageBox.Show("Usuario/Senha Inválido", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
