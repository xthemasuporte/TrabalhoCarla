namespace WinFormsApp1
{
    partial class cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblObs = new Label();
            txtObservacao = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblQtd = new Label();
            txtQtd = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtCodigo = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.BackColor = Color.Silver;
            lblNome.Font = new Font("Verdana", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.Gray;
            lblNome.Location = new Point(5, 1);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(33, 10);
            lblNome.TabIndex = 5;
            lblNome.Text = "NOME:";
            lblNome.Visible = false;
            lblNome.Click += label2_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.Silver;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Eras Demi ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.ForeColor = SystemColors.HotTrack;
            txtNome.Location = new Point(5, 10);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome:";
            txtNome.Size = new Size(238, 18);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.Enter += txtNome_Enter;
            txtNome.Leave += txtNome_Leave;
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.BackColor = Color.Silver;
            lblObs.Font = new Font("Verdana", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblObs.ForeColor = Color.Gray;
            lblObs.Location = new Point(4, 5);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(63, 10);
            lblObs.TabIndex = 7;
            lblObs.Text = "OBSERVAÇÃO:";
            lblObs.Visible = false;
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.Silver;
            txtObservacao.BorderStyle = BorderStyle.None;
            txtObservacao.Font = new Font("Eras Demi ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtObservacao.ForeColor = SystemColors.InactiveBorder;
            txtObservacao.Location = new Point(4, 14);
            txtObservacao.MaxLength = 0;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PlaceholderText = "OBSERVAÇÃO:";
            txtObservacao.Size = new Size(351, 14);
            txtObservacao.TabIndex = 4;
            txtObservacao.Enter += txtObservacao_Enter;
            txtObservacao.Leave += txtObservacao_Leave;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Green;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(8, 144);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(187, 37);
            button1.TabIndex = 5;
            button1.Text = "Casdastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(199, 144);
            button2.Name = "button2";
            button2.Size = new Size(171, 37);
            button2.TabIndex = 6;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblQtd
            // 
            lblQtd.AutoSize = true;
            lblQtd.BackColor = Color.Silver;
            lblQtd.Font = new Font("Verdana", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQtd.ForeColor = Color.Gray;
            lblQtd.Location = new Point(5, 3);
            lblQtd.Name = "lblQtd";
            lblQtd.Size = new Size(62, 10);
            lblQtd.TabIndex = 10;
            lblQtd.Text = "QUANTIDADE:";
            lblQtd.Visible = false;
            // 
            // txtQtd
            // 
            txtQtd.BackColor = Color.Silver;
            txtQtd.BorderStyle = BorderStyle.None;
            txtQtd.Font = new Font("Eras Demi ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQtd.Location = new Point(5, 12);
            txtQtd.Margin = new Padding(5);
            txtQtd.Name = "txtQtd";
            txtQtd.PlaceholderText = "Quantidade:";
            txtQtd.Size = new Size(97, 18);
            txtQtd.TabIndex = 3;
            txtQtd.Tag = "";
            txtQtd.Enter += txtQtd_Enter;
            txtQtd.Leave += txtQtd_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lblNome);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(11, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 35);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(lblObs);
            panel2.Controls.Add(txtObservacao);
            panel2.ForeColor = Color.Gray;
            panel2.Location = new Point(11, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(358, 34);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(txtQtd);
            panel3.Controls.Add(lblQtd);
            panel3.ForeColor = Color.Gray;
            panel3.Location = new Point(263, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 34);
            panel3.TabIndex = 2;
            panel3.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(txtCodigo);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(12, 23);
            panel4.Name = "panel4";
            panel4.Size = new Size(63, 34);
            panel4.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.Silver;
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Eras Demi ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.ForeColor = Color.Gray;
            txtCodigo.Location = new Point(5, 12);
            txtCodigo.Margin = new Padding(5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PlaceholderText = "Quantidade:";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(42, 18);
            txtCodigo.TabIndex = 1;
            txtCodigo.Tag = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Verdana", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(5, 3);
            label2.Name = "label2";
            label2.Size = new Size(42, 10);
            label2.TabIndex = 10;
            label2.Text = "CODIGO:";
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(380, 191);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadastro";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Carnes";
            Load += cadastro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNome;
        private Label lblObs;
        private TextBox textBox2;
        private Button button1;
        public TextBox txtNome;
        public TextBox txtObservacao;
        private Button button2;
        private Label lblQtd;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        public TextBox txtCodigo;
        public TextBox txtQtd;
    }
}