namespace projetoP2.Forms
{
    partial class formCadClientes
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
            dgvClientes = new DataGridView();
            label1 = new Label();
            btnRecarregar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtLogradouro = new TextBox();
            label7 = new Label();
            txtNumero = new TextBox();
            label8 = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            txtCidade = new TextBox();
            label10 = new Label();
            txtEstado = new TextBox();
            label11 = new Label();
            txtWhatsApp = new TextBox();
            label12 = new Label();
            txtTelefone = new TextBox();
            label13 = new Label();
            btnRegistrar = new Button();
            btnLimpar = new Button();
            btnConsultarCep = new Button();
            txtCpf = new MaskedTextBox();
            txtCep = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(330, 99);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(842, 550);
            dgvClientes.TabIndex = 0;
            dgvClientes.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 72);
            label1.Name = "label1";
            label1.Size = new Size(133, 21);
            label1.TabIndex = 1;
            label1.Text = "Tabela de Clientes";
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(1042, 68);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(130, 25);
            btnRecarregar.TabIndex = 16;
            btnRecarregar.Text = "Recarregar Tabela";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(906, 68);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(130, 25);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir Cliente";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(770, 68);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 25);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar Cliente";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 93);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(288, 23);
            txtNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "CPF:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 198);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 11;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 267);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 12;
            label6.Text = "CEP:";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(110, 293);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(190, 23);
            txtLogradouro.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 296);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 14;
            label7.Text = "Logradouro:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(110, 322);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(190, 23);
            txtNumero.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 325);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 16;
            label8.Text = "Número:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(110, 351);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(190, 23);
            txtBairro.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 354);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 18;
            label9.Text = "Bairro:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(110, 380);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(190, 23);
            txtCidade.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 383);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 20;
            label10.Text = "Cidade:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(110, 409);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(190, 23);
            txtEstado.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 412);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 22;
            label11.Text = "Estado:";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(12, 520);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(288, 23);
            txtWhatsApp.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 502);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 26;
            label12.Text = "WhatsApp:";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 466);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(288, 23);
            txtTelefone.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 448);
            label13.Name = "label13";
            label13.Size = new Size(55, 15);
            label13.TabIndex = 24;
            label13.Text = "Telefone:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 567);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(288, 38);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar Cliente";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 611);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(288, 38);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnConsultarCep
            // 
            btnConsultarCep.Location = new Point(226, 264);
            btnConsultarCep.Name = "btnConsultarCep";
            btnConsultarCep.Size = new Size(74, 23);
            btnConsultarCep.TabIndex = 4;
            btnConsultarCep.Text = "Consultar";
            btnConsultarCep.UseVisualStyleBackColor = true;
            btnConsultarCep.Click += btnConsultarCep_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 144);
            txtCpf.Mask = "999.999.999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(288, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(110, 264);
            txtCep.Mask = "99.999-999";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(110, 23);
            txtCep.TabIndex = 3;
            // 
            // formCadClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(txtCep);
            Controls.Add(txtCpf);
            Controls.Add(btnConsultarCep);
            Controls.Add(btnLimpar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtWhatsApp);
            Controls.Add(label12);
            Controls.Add(txtTelefone);
            Controls.Add(label13);
            Controls.Add(txtEstado);
            Controls.Add(label11);
            Controls.Add(txtCidade);
            Controls.Add(label10);
            Controls.Add(txtBairro);
            Controls.Add(label9);
            Controls.Add(txtNumero);
            Controls.Add(label8);
            Controls.Add(txtLogradouro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            Name = "formCadClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Clientes";
            Load += formCadClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label label1;
        private Button btnRecarregar;
        private Button btnExcluir;
        private Button btnEditar;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtLogradouro;
        private Label label7;
        private TextBox txtNumero;
        private Label label8;
        private TextBox txtBairro;
        private Label label9;
        private TextBox txtCidade;
        private Label label10;
        private TextBox txtEstado;
        private Label label11;
        private TextBox txtWhatsApp;
        private Label label12;
        private TextBox txtTelefone;
        private Label label13;
        private Button btnRegistrar;
        private Button btnLimpar;
        private Button btnConsultarCep;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtCep;
    }
}