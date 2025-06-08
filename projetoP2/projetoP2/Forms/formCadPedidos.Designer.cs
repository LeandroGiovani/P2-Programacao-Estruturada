namespace projetoP2.Forms
{
    partial class formCadPedidos
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
            txtCpf = new MaskedTextBox();
            btnConsultarCpf = new Button();
            btnLimpar = new Button();
            btnRegistrar = new Button();
            label9 = new Label();
            txtItemNome1 = new TextBox();
            label8 = new Label();
            txtItemId1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            btnExcluir = new Button();
            btnRecarregar = new Button();
            label1 = new Label();
            dgvClientes = new DataGridView();
            label3 = new Label();
            lbPreco = new Label();
            btnConsultarItemId1 = new Button();
            label4 = new Label();
            txtQtdItem1 = new TextBox();
            btnMaisItem1 = new Button();
            btnMenosItem1 = new Button();
            label5 = new Label();
            txtTotalItem1 = new TextBox();
            label10 = new Label();
            txtTotalItem2 = new TextBox();
            btnMenosItem2 = new Button();
            btnMaisItem2 = new Button();
            label11 = new Label();
            txtQtdItem2 = new TextBox();
            btnConsultarItemId2 = new Button();
            label12 = new Label();
            txtItemNome2 = new TextBox();
            label13 = new Label();
            txtItemId2 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            txtTotalItem3 = new TextBox();
            btnMenosItem3 = new Button();
            btnMaisItem3 = new Button();
            label16 = new Label();
            txtQtdItem3 = new TextBox();
            btnConsultarItemId3 = new Button();
            label17 = new Label();
            txtItemNome3 = new TextBox();
            label18 = new Label();
            txtItemId3 = new TextBox();
            label19 = new Label();
            radio1 = new RadioButton();
            label20 = new Label();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            rad3 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 43);
            txtCpf.Mask = "999.999.999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(198, 23);
            txtCpf.TabIndex = 0;
            // 
            // btnConsultarCpf
            // 
            btnConsultarCpf.Location = new Point(216, 43);
            btnConsultarCpf.Name = "btnConsultarCpf";
            btnConsultarCpf.Size = new Size(74, 23);
            btnConsultarCpf.TabIndex = 1;
            btnConsultarCpf.Text = "Consultar";
            btnConsultarCpf.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 611);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(138, 38);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(152, 611);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(138, 38);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.Text = "Registrar Pedido";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 221);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 53;
            label9.Text = "Nome item:";
            // 
            // txtItemNome1
            // 
            txtItemNome1.Location = new Point(95, 218);
            txtItemNome1.Name = "txtItemNome1";
            txtItemNome1.Size = new Size(195, 23);
            txtItemNome1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 192);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 52;
            label8.Text = "Identificador:";
            // 
            // txtItemId1
            // 
            txtItemId1.Location = new Point(95, 189);
            txtItemId1.Name = "txtItemId1";
            txtItemId1.Size = new Size(115, 23);
            txtItemId1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 167);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 49;
            label7.Text = "Item 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 25);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 46;
            label6.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 92);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(278, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 34;
            label2.Text = "Nome:";
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(906, 12);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(130, 25);
            btnExcluir.TabIndex = 23;
            btnExcluir.Text = "Excluir Pedido";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnRecarregar
            // 
            btnRecarregar.Location = new Point(1042, 12);
            btnRecarregar.Name = "btnRecarregar";
            btnRecarregar.Size = new Size(130, 25);
            btnRecarregar.TabIndex = 24;
            btnRecarregar.Text = "Recarregar Tabela";
            btnRecarregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 16);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 30;
            label1.Text = "Tabela de Pedidos";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(330, 43);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(842, 606);
            dgvClientes.TabIndex = 27;
            dgvClientes.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 583);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 56;
            label3.Text = "TOTAL:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPreco.Location = new Point(90, 583);
            lbPreco.MinimumSize = new Size(200, 0);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(200, 25);
            lbPreco.TabIndex = 57;
            lbPreco.Text = "R$ 0.00";
            lbPreco.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConsultarItemId1
            // 
            btnConsultarItemId1.Location = new Point(216, 188);
            btnConsultarItemId1.Name = "btnConsultarItemId1";
            btnConsultarItemId1.Size = new Size(74, 23);
            btnConsultarItemId1.TabIndex = 7;
            btnConsultarItemId1.Text = "Consultar";
            btnConsultarItemId1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 250);
            label4.MinimumSize = new Size(172, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 60;
            label4.Text = "Quantidade";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQtdItem1
            // 
            txtQtdItem1.BackColor = SystemColors.Window;
            txtQtdItem1.Location = new Point(58, 268);
            txtQtdItem1.Name = "txtQtdItem1";
            txtQtdItem1.ReadOnly = true;
            txtQtdItem1.Size = new Size(80, 23);
            txtQtdItem1.TabIndex = 59;
            txtQtdItem1.TabStop = false;
            // 
            // btnMaisItem1
            // 
            btnMaisItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaisItem1.Location = new Point(144, 268);
            btnMaisItem1.Name = "btnMaisItem1";
            btnMaisItem1.Size = new Size(40, 23);
            btnMaisItem1.TabIndex = 10;
            btnMaisItem1.Text = "+";
            btnMaisItem1.UseVisualStyleBackColor = true;
            // 
            // btnMenosItem1
            // 
            btnMenosItem1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenosItem1.Location = new Point(12, 268);
            btnMenosItem1.Name = "btnMenosItem1";
            btnMenosItem1.Size = new Size(40, 23);
            btnMenosItem1.TabIndex = 9;
            btnMenosItem1.Text = "-";
            btnMenosItem1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 251);
            label5.MinimumSize = new Size(99, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 64;
            label5.Text = "Total Item 1";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTotalItem1
            // 
            txtTotalItem1.BackColor = SystemColors.Window;
            txtTotalItem1.Location = new Point(191, 269);
            txtTotalItem1.Name = "txtTotalItem1";
            txtTotalItem1.ReadOnly = true;
            txtTotalItem1.Size = new Size(99, 23);
            txtTotalItem1.TabIndex = 63;
            txtTotalItem1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(191, 387);
            label10.MinimumSize = new Size(99, 0);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 76;
            label10.Text = "Total Item 1";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Visible = false;
            // 
            // txtTotalItem2
            // 
            txtTotalItem2.BackColor = SystemColors.Window;
            txtTotalItem2.Location = new Point(191, 405);
            txtTotalItem2.Name = "txtTotalItem2";
            txtTotalItem2.ReadOnly = true;
            txtTotalItem2.Size = new Size(99, 23);
            txtTotalItem2.TabIndex = 75;
            txtTotalItem2.TabStop = false;
            txtTotalItem2.Visible = false;
            // 
            // btnMenosItem2
            // 
            btnMenosItem2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenosItem2.Location = new Point(12, 404);
            btnMenosItem2.Name = "btnMenosItem2";
            btnMenosItem2.Size = new Size(40, 23);
            btnMenosItem2.TabIndex = 14;
            btnMenosItem2.Text = "-";
            btnMenosItem2.UseVisualStyleBackColor = true;
            btnMenosItem2.Visible = false;
            // 
            // btnMaisItem2
            // 
            btnMaisItem2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaisItem2.Location = new Point(144, 404);
            btnMaisItem2.Name = "btnMaisItem2";
            btnMaisItem2.Size = new Size(40, 23);
            btnMaisItem2.TabIndex = 15;
            btnMaisItem2.Text = "+";
            btnMaisItem2.UseVisualStyleBackColor = true;
            btnMaisItem2.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 386);
            label11.MinimumSize = new Size(172, 0);
            label11.Name = "label11";
            label11.Size = new Size(172, 15);
            label11.TabIndex = 74;
            label11.Text = "Quantidade";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Visible = false;
            // 
            // txtQtdItem2
            // 
            txtQtdItem2.BackColor = SystemColors.Window;
            txtQtdItem2.Location = new Point(58, 404);
            txtQtdItem2.Name = "txtQtdItem2";
            txtQtdItem2.ReadOnly = true;
            txtQtdItem2.Size = new Size(80, 23);
            txtQtdItem2.TabIndex = 73;
            txtQtdItem2.TabStop = false;
            txtQtdItem2.Visible = false;
            // 
            // btnConsultarItemId2
            // 
            btnConsultarItemId2.Location = new Point(216, 324);
            btnConsultarItemId2.Name = "btnConsultarItemId2";
            btnConsultarItemId2.Size = new Size(74, 23);
            btnConsultarItemId2.TabIndex = 12;
            btnConsultarItemId2.Text = "Consultar";
            btnConsultarItemId2.UseVisualStyleBackColor = true;
            btnConsultarItemId2.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 357);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 72;
            label12.Text = "Nome item:";
            label12.Visible = false;
            // 
            // txtItemNome2
            // 
            txtItemNome2.Location = new Point(95, 354);
            txtItemNome2.Name = "txtItemNome2";
            txtItemNome2.Size = new Size(195, 23);
            txtItemNome2.TabIndex = 13;
            txtItemNome2.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 328);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 71;
            label13.Text = "Identificador:";
            label13.Visible = false;
            // 
            // txtItemId2
            // 
            txtItemId2.Location = new Point(95, 325);
            txtItemId2.Name = "txtItemId2";
            txtItemId2.Size = new Size(115, 23);
            txtItemId2.TabIndex = 11;
            txtItemId2.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 303);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 70;
            label14.Text = "Item 2:";
            label14.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(191, 519);
            label15.MinimumSize = new Size(99, 0);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 88;
            label15.Text = "Total Item 1";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            label15.Visible = false;
            // 
            // txtTotalItem3
            // 
            txtTotalItem3.BackColor = SystemColors.Window;
            txtTotalItem3.Location = new Point(191, 537);
            txtTotalItem3.Name = "txtTotalItem3";
            txtTotalItem3.ReadOnly = true;
            txtTotalItem3.Size = new Size(99, 23);
            txtTotalItem3.TabIndex = 87;
            txtTotalItem3.TabStop = false;
            txtTotalItem3.Visible = false;
            // 
            // btnMenosItem3
            // 
            btnMenosItem3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenosItem3.Location = new Point(12, 536);
            btnMenosItem3.Name = "btnMenosItem3";
            btnMenosItem3.Size = new Size(40, 23);
            btnMenosItem3.TabIndex = 19;
            btnMenosItem3.Text = "-";
            btnMenosItem3.UseVisualStyleBackColor = true;
            btnMenosItem3.Visible = false;
            // 
            // btnMaisItem3
            // 
            btnMaisItem3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaisItem3.Location = new Point(144, 536);
            btnMaisItem3.Name = "btnMaisItem3";
            btnMaisItem3.Size = new Size(40, 23);
            btnMaisItem3.TabIndex = 20;
            btnMaisItem3.Text = "+";
            btnMaisItem3.UseVisualStyleBackColor = true;
            btnMaisItem3.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 518);
            label16.MinimumSize = new Size(172, 0);
            label16.Name = "label16";
            label16.Size = new Size(172, 15);
            label16.TabIndex = 86;
            label16.Text = "Quantidade";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Visible = false;
            // 
            // txtQtdItem3
            // 
            txtQtdItem3.BackColor = SystemColors.Window;
            txtQtdItem3.Location = new Point(58, 536);
            txtQtdItem3.Name = "txtQtdItem3";
            txtQtdItem3.ReadOnly = true;
            txtQtdItem3.Size = new Size(80, 23);
            txtQtdItem3.TabIndex = 85;
            txtQtdItem3.TabStop = false;
            txtQtdItem3.Visible = false;
            // 
            // btnConsultarItemId3
            // 
            btnConsultarItemId3.Location = new Point(216, 456);
            btnConsultarItemId3.Name = "btnConsultarItemId3";
            btnConsultarItemId3.Size = new Size(74, 23);
            btnConsultarItemId3.TabIndex = 17;
            btnConsultarItemId3.Text = "Consultar";
            btnConsultarItemId3.UseVisualStyleBackColor = true;
            btnConsultarItemId3.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(12, 489);
            label17.Name = "label17";
            label17.Size = new Size(70, 15);
            label17.TabIndex = 84;
            label17.Text = "Nome item:";
            label17.Visible = false;
            // 
            // txtItemNome3
            // 
            txtItemNome3.Location = new Point(95, 486);
            txtItemNome3.Name = "txtItemNome3";
            txtItemNome3.Size = new Size(195, 23);
            txtItemNome3.TabIndex = 18;
            txtItemNome3.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 460);
            label18.Name = "label18";
            label18.Size = new Size(77, 15);
            label18.TabIndex = 83;
            label18.Text = "Identificador:";
            label18.Visible = false;
            // 
            // txtItemId3
            // 
            txtItemId3.Location = new Point(95, 457);
            txtItemId3.Name = "txtItemId3";
            txtItemId3.Size = new Size(115, 23);
            txtItemId3.TabIndex = 16;
            txtItemId3.Visible = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 435);
            label19.Name = "label19";
            label19.Size = new Size(43, 15);
            label19.TabIndex = 82;
            label19.Text = "Item 3:";
            label19.Visible = false;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(90, 134);
            radio1.Name = "radio1";
            radio1.Size = new Size(31, 19);
            radio1.TabIndex = 89;
            radio1.Text = "1";
            radio1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(12, 136);
            label20.Name = "label20";
            label20.Size = new Size(116, 15);
            label20.TabIndex = 90;
            label20.Text = "Quantidade de Itens:";
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Checked = true;
            rad1.Location = new Point(179, 136);
            rad1.Name = "rad1";
            rad1.Size = new Size(31, 19);
            rad1.TabIndex = 3;
            rad1.TabStop = true;
            rad1.Text = "1";
            rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(216, 136);
            rad2.Name = "rad2";
            rad2.Size = new Size(31, 19);
            rad2.TabIndex = 4;
            rad2.Text = "2";
            rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(253, 136);
            rad3.Name = "rad3";
            rad3.Size = new Size(31, 19);
            rad3.TabIndex = 5;
            rad3.Text = "3";
            rad3.UseVisualStyleBackColor = true;
            // 
            // formCadPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(rad3);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Controls.Add(label20);
            Controls.Add(radio1);
            Controls.Add(label15);
            Controls.Add(txtTotalItem3);
            Controls.Add(btnMenosItem3);
            Controls.Add(btnMaisItem3);
            Controls.Add(label16);
            Controls.Add(txtQtdItem3);
            Controls.Add(btnConsultarItemId3);
            Controls.Add(label17);
            Controls.Add(txtItemNome3);
            Controls.Add(label18);
            Controls.Add(txtItemId3);
            Controls.Add(label19);
            Controls.Add(label10);
            Controls.Add(txtTotalItem2);
            Controls.Add(btnMenosItem2);
            Controls.Add(btnMaisItem2);
            Controls.Add(label11);
            Controls.Add(txtQtdItem2);
            Controls.Add(btnConsultarItemId2);
            Controls.Add(label12);
            Controls.Add(txtItemNome2);
            Controls.Add(label13);
            Controls.Add(txtItemId2);
            Controls.Add(label14);
            Controls.Add(label5);
            Controls.Add(txtTotalItem1);
            Controls.Add(btnMenosItem1);
            Controls.Add(btnMaisItem1);
            Controls.Add(label4);
            Controls.Add(txtQtdItem1);
            Controls.Add(btnConsultarItemId1);
            Controls.Add(lbPreco);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(btnConsultarCpf);
            Controls.Add(btnLimpar);
            Controls.Add(btnRegistrar);
            Controls.Add(label9);
            Controls.Add(txtItemNome1);
            Controls.Add(label8);
            Controls.Add(txtItemId1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(dgvClientes);
            Name = "formCadPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Pedidos";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCep;
        private MaskedTextBox txtCpf;
        private Button btnConsultarCpf;
        private Button btnLimpar;
        private Button btnRegistrar;
        private Label label9;
        private TextBox txtItemNome1;
        private Label label8;
        private TextBox txtItemId1;
        private Label label7;
        private Label label6;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNome;
        private Label label2;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnRecarregar;
        private Label label1;
        private DataGridView dgvClientes;
        private Label label3;
        private Label lbPreco;
        private Button btnConsultarItemId1;
        private TextBox txtQtdItem1;
        private Button btnMaisItem1;
        private Button btnMenosItem1;
        private Label label5;
        private TextBox txtTotalItem1;
        private Label label10;
        private TextBox txtTotalItem2;
        private Button btnMenosItem2;
        private Button btnMaisItem2;
        private Label label11;
        private TextBox txtQtdItem2;
        private Button btnConsultarItemId2;
        private Label label12;
        private TextBox txtItemNome2;
        private Label label13;
        private TextBox txtItemId2;
        private Label label14;
        private Label label15;
        private TextBox txtTotalItem3;
        private Button btnMenosItem3;
        private Button btnMaisItem3;
        private Label label16;
        private TextBox txtQtdItem3;
        private Button btnConsultarItemId3;
        private Label label17;
        private TextBox txtItemNome3;
        private Label label18;
        private TextBox txtItemId3;
        private Label label19;
        private RadioButton radio1;
        private Label label20;
        private RadioButton rad1;
        private RadioButton rad2;
        private RadioButton rad3;
    }
}