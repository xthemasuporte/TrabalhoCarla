namespace WinFormsApp1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            carnesToolStripMenuItem = new ToolStripMenuItem();
            kitsToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            tabelaDeKitsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(198, 0, 5);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, sairToolStripMenuItem, tabelaDeKitsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carnesToolStripMenuItem, kitsToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cadastroToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(94, 22);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // carnesToolStripMenuItem
            // 
            carnesToolStripMenuItem.Name = "carnesToolStripMenuItem";
            carnesToolStripMenuItem.Size = new Size(133, 22);
            carnesToolStripMenuItem.Text = "Carnes";
            carnesToolStripMenuItem.Click += carnesToolStripMenuItem_Click;
            // 
            // kitsToolStripMenuItem
            // 
            kitsToolStripMenuItem.Name = "kitsToolStripMenuItem";
            kitsToolStripMenuItem.Size = new Size(133, 22);
            kitsToolStripMenuItem.Text = "Kits";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sairToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(52, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // tabelaDeKitsToolStripMenuItem
            // 
            tabelaDeKitsToolStripMenuItem.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabelaDeKitsToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            tabelaDeKitsToolStripMenuItem.Name = "tabelaDeKitsToolStripMenuItem";
            tabelaDeKitsToolStripMenuItem.Size = new Size(134, 22);
            tabelaDeKitsToolStripMenuItem.Text = "Tabela de kits";
            tabelaDeKitsToolStripMenuItem.Click += tabelaDeKitsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 424);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(234, 234, 234);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem carnesToolStripMenuItem;
        private ToolStripMenuItem kitsToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem tabelaDeKitsToolStripMenuItem;
    }
}