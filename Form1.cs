using System.Collections;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public ArrayList listaCarnes;
        public int lastCodigo;
        public string editar;

        private string codigo_atual = "";
        private string nome_atual = "";
        private string quantidade_atual = "";
        private string observacao_atual = "";
        private int indice_atual = 0;
        public Form1()
        {
            InitializeComponent();
            
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (String carne in listaCarnes)
            {
                string[] linha_carne = carne.Split(';');
                dataGridView1.Rows.Add(linha_carne);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cadastro cadastro = new cadastro();
            cadastro.txtCodigo.Text = (lastCodigo + 1).ToString();
            if (cadastro.ShowDialog() == DialogResult.OK)
            {
                string[] carne = [cadastro.txtCodigo.Text, cadastro.txtNome.Text, cadastro.txtQtd.Text, cadastro.txtObservacao.Text];
                listaCarnes.Add(carne[0] + ";" + carne[1] + ";" + carne[2] + ";" + carne[3]);
                dataGridView1.Rows.Add(carne);
                lastCodigo += 1;

            }



        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            cadastro cadastro = new cadastro();
            cadastro.txtCodigo.Text = codigo_atual;
            cadastro.txtNome.Text = nome_atual;
            cadastro.txtQtd.Text = quantidade_atual;
            if (cadastro.ShowDialog() == DialogResult.OK)
            {
               string[] carneEditar = [cadastro.txtCodigo.Text, cadastro.txtNome.Text, cadastro.txtQtd.Text, cadastro.txtObservacao.Text];
                listaCarnes[indice_atual] = carneEditar;
                dataGridView1.Rows[indice_atual].Cells[0].Value = carneEditar[0];
                dataGridView1.Rows[indice_atual].Cells[1].Value = carneEditar[1];
                dataGridView1.Rows[indice_atual].Cells[2].Value = carneEditar[2];
                dataGridView1.Rows[indice_atual].Cells[3].Value = carneEditar[3];
            }
            





        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y); //Busca as coordenadas do click do mouse
                if (hit.RowIndex >= 0)
                {
                    indice_atual = hit.RowIndex;
                    codigo_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[0].Value.ToString();
                    nome_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[1].Value.ToString();
                    quantidade_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[2].Value.ToString();
                    //codigo_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[0].Value.ToString();
                    ((DataGridView)sender).Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir " + nome_atual, "Exclusão de Carne", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                listaCarnes.RemoveAt(indice_atual);
                dataGridView1.Rows.RemoveAt(indice_atual);
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
