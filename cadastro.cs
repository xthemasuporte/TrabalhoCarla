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
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            lblNome.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }










        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtObservacao_Enter(object sender, EventArgs e)
        {
            lblObs.Visible = true;
        }

        private void txtObservacao_Leave(object sender, EventArgs e)
        {
            lblObs.Visible = (txtObservacao.Text.Trim() != "");
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            lblNome.Visible = (txtNome.Text.Trim() != "");
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            lblNome.Visible = true;
        }

        private void txtQtd_Leave(object sender, EventArgs e)
        {
            lblQtd.Visible = (txtQtd.Text.Trim() != "");
        }

        private void txtQtd_Enter(object sender, EventArgs e)
        {
            lblQtd.Visible = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
