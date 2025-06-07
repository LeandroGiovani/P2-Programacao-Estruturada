namespace projetoP2.Forms
{
    partial class formCadProdutos
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
            btnLimpar = new Button();
            btnRegistrar = new Button();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtNomeProduto = new TextBox();
            label2 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnRecarregar = new Button();
            label1 = new Label();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 376);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(288, 38);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 332);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(288, 38);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar Produto";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(12, 166);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(288, 23);
            txtPreco.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 220);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(288, 91);
            txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 202);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 41;
            label4.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 38;
            label3.Text = "Preço:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(12, 115);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(288, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 34;
            label2.Text = "Nome do Produto:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(770, 63);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 25);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar Produto";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(906, 63);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(130, 25);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir Produto";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(1042, 63);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(130, 25);
            btnRecarregar.TabIndex = 7;
            btnRecarregar.Text = "Recarregar Tabela";
            btnRecarregar.UseVisualStyleBackColor = true;
            btnRecarregar.Click += btnRecarregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 67);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 30;
            label1.Text = "Tabela de Produtos";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(330, 99);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(842, 550);
            dgvProdutos.TabIndex = 27;
            dgvProdutos.TabStop = false;
            // 
            // formCadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(btnLimpar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNomeProduto);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(dgvProdutos);
            Name = "formCadProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Produtos";
            Load += formCadProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnRegistrar;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Label label4;
        private Label label3;
        private TextBox txtNomeProduto;
        private Label label2;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnRecarregar;
        private Label label1;
        private DataGridView dgvProdutos;
    }
}