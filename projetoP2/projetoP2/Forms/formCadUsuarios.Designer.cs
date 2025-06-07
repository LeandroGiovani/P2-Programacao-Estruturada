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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            cadastrarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            atualizarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            voltarToolStripMenuItem = new ToolStripMenuItem();
            lbBemVindo = new Label();
            btnAlterarSenha = new Button();
            txtAlterarSenha = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSenha = new TextBox();
            btnSalvar = new Button();
            dgvUsuarios = new DataGridView();
            label3 = new Label();
            btnRecarregar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarUsuárioToolStripMenuItem, atualizarUsuárioToolStripMenuItem, voltarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            cadastrarUsuárioToolStripMenuItem.Size = new Size(112, 20);
            cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            cadastrarUsuárioToolStripMenuItem.Click += cadastrarUsuárioToolStripMenuItem_Click;
            // 
            // atualizarUsuárioToolStripMenuItem
            // 
            atualizarUsuárioToolStripMenuItem.Name = "atualizarUsuárioToolStripMenuItem";
            atualizarUsuárioToolStripMenuItem.Size = new Size(108, 20);
            atualizarUsuárioToolStripMenuItem.Text = "Atualizar Usuário";
            atualizarUsuárioToolStripMenuItem.Click += atualizarUsuárioToolStripMenuItem_Click;
            // 
            // voltarToolStripMenuItem
            // 
            voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            voltarToolStripMenuItem.Size = new Size(49, 20);
            voltarToolStripMenuItem.Text = "Voltar";
            voltarToolStripMenuItem.Click += voltarToolStripMenuItem_Click;
            // 
            // lbBemVindo
            // 
            lbBemVindo.AutoSize = true;
            lbBemVindo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbBemVindo.Location = new Point(772, 43);
            lbBemVindo.MaximumSize = new Size(300, 0);
            lbBemVindo.MinimumSize = new Size(300, 0);
            lbBemVindo.Name = "lbBemVindo";
            lbBemVindo.RightToLeft = RightToLeft.Yes;
            lbBemVindo.Size = new Size(300, 21);
            lbBemVindo.TabIndex = 1;
            lbBemVindo.Text = "Olá usuario";
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(896, 79);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(176, 23);
            btnAlterarSenha.TabIndex = 2;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // txtAlterarSenha
            // 
            txtAlterarSenha.Location = new Point(896, 108);
            txtAlterarSenha.Name = "txtAlterarSenha";
            txtAlterarSenha.Size = new Size(176, 23);
            txtAlterarSenha.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(326, 23);
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
            txtSenha.Size = new Size(326, 23);
            txtSenha.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(178, 163);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(160, 31);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Cadastrar Usuário";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 250);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1060, 399);
            dgvUsuarios.TabIndex = 9;
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
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(944, 217);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(128, 27);
            btnRecarregar.TabIndex = 11;
            btnRecarregar.Text = "Recarregar Tabela";
            btnRecarregar.UseVisualStyleBackColor = true;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(810, 217);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 27);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir Usuário";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 163);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(160, 31);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // formCadUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRecarregar);
            Controls.Add(label3);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(txtSenha);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtAlterarSenha);
            Controls.Add(btnAlterarSenha);
            Controls.Add(lbBemVindo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formCadUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Usuários";
            Load += formCadUsuarios_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private ToolStripMenuItem atualizarUsuárioToolStripMenuItem;
        private ToolStripMenuItem voltarToolStripMenuItem;
        private Label lbBemVindo;
        private Button btnAlterarSenha;
        private TextBox txtAlterarSenha;
        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtSenha;
        private Button btnSalvar;
        private DataGridView dgvUsuarios;
        private Label label3;
        private Button btnRecarregar;
        private Button btnExcluir;
        private Button btnLimpar;
    }
}