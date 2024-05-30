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
    {
        ArrayList carnes;
        int lastCode = 4;
        public FormPrincipal()
        {
            
                InitializeComponent();
                carnes = new ArrayList();

                carnes.Add("1;Picanha;10");
                carnes.Add("2;Maminha;5");
                carnes.Add("3;File de Frango;4");
                carnes.Add("4;Picanha;10");



        }

        private void carnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 telacadastrocarne = new Form1();
            telacadastrocarne.listaCarnes = carnes;
            telacadastrocarne.lastCodigo = lastCode;
            telacadastrocarne.ShowDialog();
            carnes = telacadastrocarne.listaCarnes;
            lastCode = telacadastrocarne.lastCodigo;

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Sair? ", "Sair do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tabelaDeKitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKits telakits = new FormKits();
            telakits.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Form2 login = new Form2();

            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Close();

            }
            


        }
    }
}
