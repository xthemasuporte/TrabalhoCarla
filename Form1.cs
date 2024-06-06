using System.Collections;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Declarando todas as variaveis usadas nessa tela 
        public ArrayList listaCarnes;
        public int lastCodigo;
        public string editar;
        //Declarando e inicializando as variaveis utilizadas na tela.
        private string codigo_atual = "";
        private string nome_atual = "";
        private string quantidade_atual = "";
        private string observacao_atual = "";
        private int indice_atual = 0;


        
        /// <summary>
        /// Inicializa a Tela
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Codigo Executado quando a Tela é Carregada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        { 
            //Adicionando novos items a tabela (grid) usando foreach=
            foreach (String carne in listaCarnes)
            {
                //Transforma a string em um array, quebrando-o pelo ";"
                string[] linha_carne = carne.Split(';');
                dataGridView1.Rows.Add(linha_carne);
            }
        }
        /// <summary>
        /// Codigo Executado quando o Botão Cadatrar for clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            //Cria o objeto cadastro (tela)
            cadastro cadastro = new cadastro();
            //Preenche o texto do TextBox com o ultimo código + 1
            cadastro.txtCodigo.Text = (lastCodigo + 1).ToString();

            //Mostra a tela e verifica se a tela retornou um valor OK.
            if (cadastro.ShowDialog() == DialogResult.OK)
            {
                //Cria um array com os valores dos TextBox da tela.
                string[] carne = [cadastro.txtCodigo.Text, cadastro.txtNome.Text, cadastro.txtQtd.Text, cadastro.txtObservacao.Text];
                //Adiciona um item no ArrayList - uma string separada por ";"
                listaCarnes.Add(carne[0] + ";" + carne[1] + ";" + carne[2] + ";" + carne[3]);
                //adiciona o array na tabela (grid)
                dataGridView1.Rows.Add(carne);
                //Incrementa a variavel que mantem o ultimo codigo utilizado
                lastCodigo += 1;
            }
        }
        /// <summary>
        /// Codigo executado quando o Item Editar do Menu Suspenso for Clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Cria o objeto cadastro (tela)
            cadastro cadastro = new cadastro();

            //Preenche os TextBox da Tela com os "valores atuais"
            cadastro.txtCodigo.Text = codigo_atual;
            cadastro.txtNome.Text = nome_atual;
            cadastro.txtQtd.Text = quantidade_atual;


            //Mostra a tela e verifica se a tela retornou um valor OK.
            if (cadastro.ShowDialog() == DialogResult.OK)
            {
                //Cria um array com os valores dos TextBox da tela.
                string[] carneEditar = [cadastro.txtCodigo.Text, cadastro.txtNome.Text, cadastro.txtQtd.Text, cadastro.txtObservacao.Text];
                //Substitui o item do ArrayList correspondente ao indice_atual pelo novo array
                listaCarnes[indice_atual] = carneEditar;

                //Altera os valores das Celulas da Row (linha) da tabela (grid) pelos novos valores contidos no array
                dataGridView1.Rows[indice_atual].Cells[0].Value = carneEditar[0];
                dataGridView1.Rows[indice_atual].Cells[1].Value = carneEditar[1];
                dataGridView1.Rows[indice_atual].Cells[2].Value = carneEditar[2];
                dataGridView1.Rows[indice_atual].Cells[3].Value = carneEditar[3];
            }
        }
        /// <summary>
        /// Metodo executado pelo botão quando clicado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            //Verifica se o Botão Clicado é o Direito
            if (e.Button == MouseButtons.Right)
            {
                //Busca as coordenadas do click do mouse para usar como referencia para Editar o item atual
                DataGridView.HitTestInfo hit = dataGridView1.HitTest(e.X, e.Y);
                //Verifica se a linha clicada é valida, ou seja, maior ou igual a zero
                if (hit.RowIndex >= 0)
                {
                    //Armazena o indice da linha clicada em uma variavel indicie atual
                    indice_atual = hit.RowIndex;
                    //Armazena os valores das Celulas da Linha nas variaveis atuais.
                    codigo_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[0].Value.ToString();
                    nome_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[1].Value.ToString();
                    quantidade_atual = ((DataGridView)sender).Rows[hit.RowIndex].Cells[2].Value.ToString();
                    //Seleciona a linha atual.
                    ((DataGridView)sender).Rows[hit.RowIndex].Selected = true;
                    //Mostra o menu de opcoes no local onde foi clicado o mouse.
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }
        /// <summary>
        /// Codigo executado quando o Item Excluir do Menu Suspenso for clicado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Mostra caixa de dialogo se deseja realmente excluir o item selecionado
            DialogResult dialogResult = MessageBox.Show("Deseja Excluir " + nome_atual, "Exclusão de Carne", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Verifica se o botão da Caixa de Dialogo clicado foi o SIM
            if (dialogResult == DialogResult.Yes)
            {
                //Remove do ArrayList o registro armazenado na posicao indicada pela variavel indice_atual
                listaCarnes.RemoveAt(indice_atual);
                //Remove a linha atual selecionada da tebela (grid)
                dataGridView1.Rows.RemoveAt(indice_atual);
            }
        }
    }
}
