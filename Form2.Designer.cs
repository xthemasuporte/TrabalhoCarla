namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            panel1 = new Panel();
            txtSenha = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(198, 0, 5);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(443, 40);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(70, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 172);
            panel1.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.FromArgb(234, 234, 234);
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.ForeColor = Color.FromArgb(198, 0, 5);
            txtSenha.Location = new Point(11, 132);
            txtSenha.Margin = new Padding(0);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "ex: 12345678";
            txtSenha.Size = new Size(262, 16);
            txtSenha.TabIndex = 5;
            txtSenha.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(198, 0, 5);
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(128, 16);
            label5.TabIndex = 4;
            label5.Text = "Digite sua Senha";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(234, 234, 234);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.FromArgb(198, 0, 5);
            txtEmail.Location = new Point(11, 82);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "contato@gmail.com";
            txtEmail.Size = new Size(262, 16);
            txtEmail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(198, 0, 5);
            label4.Location = new Point(6, 63);
            label4.Name = "label4";
            label4.Size = new Size(123, 16);
            label4.TabIndex = 2;
            label4.Text = "Digite seu Email";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(234, 234, 234);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.FromArgb(198, 0, 5);
            textBox1.Location = new Point(11, 27);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ex: Caua Peres";
            textBox1.Size = new Size(262, 16);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(198, 0, 5);
            label3.Location = new Point(6, 5);
            label3.Name = "label3";
            label3.Size = new Size(125, 16);
            label3.TabIndex = 0;
            label3.Text = "Digite seu Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(198, 0, 5);
            label2.Location = new Point(29, 40);
            label2.Name = "label2";
            label2.Size = new Size(402, 15);
            label2.TabIndex = 3;
            label2.Text = "_______________________________________________________________________________";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(198, 0, 5);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(288, 271);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 4;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 234, 234);
            ClientSize = new Size(443, 327);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.Brown;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carne Nobre - Login";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtSenha;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Button button1;
    }
}