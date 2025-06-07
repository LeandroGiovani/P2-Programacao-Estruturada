namespace projetoP2.Forms
{
    partial class formCadUsuarios
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
            menuStrip1 = new MenuStrip();
            cadastrarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            atualizarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            excluirUsuárioToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            lbBemVindo = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            btnSalvar = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarUsuárioToolStripMenuItem, atualizarUsuárioToolStripMenuItem, excluirUsuárioToolStripMenuItem, voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1046, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            cadastrarUsuárioToolStripMenuItem.Size = new Size(112, 20);
            cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            // 
            // atualizarUsuárioToolStripMenuItem
            // 
            atualizarUsuárioToolStripMenuItem.Name = "atualizarUsuárioToolStripMenuItem";
            atualizarUsuárioToolStripMenuItem.Size = new Size(108, 20);
            atualizarUsuárioToolStripMenuItem.Text = "Atualizar Usuário";
            // 
            // excluirUsuárioToolStripMenuItem
            // 
            excluirUsuárioToolStripMenuItem.Name = "excluirUsuárioToolStripMenuItem";
            excluirUsuárioToolStripMenuItem.Size = new Size(96, 20);
            excluirUsuárioToolStripMenuItem.Text = "Excluir Usuário";
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            // 
            // lbBemVindo
            // 
            lbBemVindo.AutoSize = true;
            lbBemVindo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBemVindo.Location = new Point(944, 42);
            lbBemVindo.Name = "lbBemVindo";
            lbBemVindo.RightToLeft = RightToLeft.Yes;
            lbBemVindo.Size = new Size(90, 21);
            lbBemVindo.TabIndex = 1;
            lbBemVindo.Text = "Olá usuario";
            // 
            // button1
            // 
            button1.Location = new Point(922, 79);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 2;
            button1.Text = "Alterar Senha";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(922, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 23);
            textBox1.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(170, 23);
            txtNome.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 7;
            label2.Text = "Senha:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 121);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(170, 23);
            txtSenha.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 163);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(170, 31);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1022, 363);
            dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 226);
            label3.Name = "label3";
            label3.Size = new Size(139, 21);
            label3.TabIndex = 10;
            label3.Text = "Tabela de Usuários";
            // 
            // button2
            // 
            button2.Location = new Point(906, 217);
            button2.Name = "button2";
            button2.Size = new Size(128, 27);
            button2.TabIndex = 11;
            button2.Text = "Recarregar Tabela";
            button2.UseVisualStyleBackColor = true;
            // 
            // formCadUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 625);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(lbBemVindo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formCadUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Usuários";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private ToolStripMenuItem atualizarUsuárioToolStripMenuItem;
        private ToolStripMenuItem excluirUsuárioToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private Label lbBemVindo;
        private Button button1;
        private TextBox textBox1;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private Button btnSalvar;
        private DataGridView dataGridView1;
        private Label label3;
        private Button button2;
    }
}