using System;
using System.Collections;
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
    public partial class FormPrincipal : Form
    {//criando o array principal dessa tela e passando a informaçao de referencia sobre o codigo do produto
        ArrayList carnes;
        int lastCode = 4;
        public FormPrincipal()
        {//adcionando itens constantes na tabela para dar continuidade e ter referencia para o sistema e para o usuario
            InitializeComponent();
            //Criando array carnes
            carnes = new ArrayList();
            //Adcionando ao array carnes algumas informações para dar continuidade e ter referencia para o sistema
            carnes.Add("1;Picanha;10");
            carnes.Add("2;Maminha;5");
            carnes.Add("3;File de Frango;4");
            carnes.Add("4;Picanha;10");
        }

        private void carnesToolStripMenuItem_Click(object sender, EventArgs e)
        {   //Chamando um novo form
            Form1 telacadastrocarne = new Form1();
            //telacadastrocarne.listaCarnes Recebe o valor de carnes
            telacadastrocarne.listaCarnes = carnes;
            //telacadastrocarne.lastCodigo Recebe o valor de lastCode
            telacadastrocarne.lastCodigo = lastCode;
            //Mostra caixa de dialogo
            telacadastrocarne.ShowDialog();
            //Carnes recebe o valor de telacadastrocarne.listacarne para atualizar 
            carnes = telacadastrocarne.listaCarnes;
            //Carnes recebe o valor de telacadastrocarne.lastCodigo para atualizar 
            lastCode = telacadastrocarne.lastCodigo;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//Resultado do dialogo vai ser oq o usuario escolher
            DialogResult dialogResult = MessageBox.Show("Deseja Sair? ", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //se o resultado do dialogo for yes ele ira sair da aplicação encerrando todos os processos
            if (dialogResult == DialogResult.Yes)
            {    //Fecha a aplicação e encerra todos os processos
                Application.Exit();
            }
        }

        private void tabelaDeKitsToolStripMenuItem_Click(object sender, EventArgs e)
        {//Chamando outro form
            FormKits telakits = new FormKits();
            //Mostrando Caixa de dialogo
            telakits.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {//fazendo com que a tela de login ou form2 seja fechada assim que a tela principal é iniciada
            Form2 login = new Form2();
            //Se resultado da tela de login for ok(For sucedido) ele ira fechar a tela
            if (login.ShowDialog() != DialogResult.OK)
            {    //Fechando o form 
                this.Close();
            }
        }
    }
}

