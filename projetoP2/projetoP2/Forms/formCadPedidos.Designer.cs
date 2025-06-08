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
            lbNomeItem1 = new Label();
            txtItemNome1 = new TextBox();
            lbItemId1 = new Label();
            txtItemId1 = new TextBox();
            lbItem1 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            btnExcluir = new Button();
            btnRecarregar = new Button();
            label1 = new Label();
            dgvPedidos = new DataGridView();
            label3 = new Label();
            lbPreco = new Label();
            btnConsultarItemId1 = new Button();
            lbQuantidadeItem1 = new Label();
            txtQtdItem1 = new TextBox();
            btnMaisItem1 = new Button();
            btnMenosItem1 = new Button();
            lbTotalItem1 = new Label();
            txtTotalItem1 = new TextBox();
            lbTotalItem2 = new Label();
            txtTotalItem2 = new TextBox();
            btnMenosItem2 = new Button();
            btnMaisItem2 = new Button();
            lbQuantidadeItem2 = new Label();
            txtQtdItem2 = new TextBox();
            btnConsultarItemId2 = new Button();
            lbNomeItem2 = new Label();
            txtItemNome2 = new TextBox();
            lbItemId2 = new Label();
            txtItemId2 = new TextBox();
            lbItem2 = new Label();
            lbTotalItem3 = new Label();
            txtTotalItem3 = new TextBox();
            btnMenosItem3 = new Button();
            btnMaisItem3 = new Button();
            lbQuantidadeItem3 = new Label();
            txtQtdItem3 = new TextBox();
            btnConsultarItemId3 = new Button();
            lbNomeItem3 = new Label();
            txtItemNome3 = new TextBox();
            lbItemId3 = new Label();
            txtItemId3 = new TextBox();
            lbItem3 = new Label();
            radio1 = new RadioButton();
            label20 = new Label();
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            rad3 = new RadioButton();
            txtIdRegistro = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(58, 43);
            txtCpf.Mask = "999.999.999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(152, 23);
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
            btnConsultarCpf.Click += btnConsultarCpf_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 611);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(138, 38);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(152, 611);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(138, 38);
            btnRegistrar.TabIndex = 22;
            btnRegistrar.Text = "Registrar Pedido";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbNomeItem1
            // 
            lbNomeItem1.AutoSize = true;
            lbNomeItem1.Location = new Point(12, 221);
            lbNomeItem1.Name = "lbNomeItem1";
            lbNomeItem1.Size = new Size(70, 15);
            lbNomeItem1.TabIndex = 53;
            lbNomeItem1.Text = "Nome item:";
            // 
            // txtItemNome1
            // 
            txtItemNome1.BackColor = SystemColors.Window;
            txtItemNome1.Location = new Point(95, 218);
            txtItemNome1.Name = "txtItemNome1";
            txtItemNome1.ReadOnly = true;
            txtItemNome1.Size = new Size(195, 23);
            txtItemNome1.TabIndex = 8;
            // 
            // lbItemId1
            // 
            lbItemId1.AutoSize = true;
            lbItemId1.Location = new Point(12, 192);
            lbItemId1.Name = "lbItemId1";
            lbItemId1.Size = new Size(77, 15);
            lbItemId1.TabIndex = 52;
            lbItemId1.Text = "Identificador:";
            // 
            // txtItemId1
            // 
            txtItemId1.Location = new Point(95, 189);
            txtItemId1.Name = "txtItemId1";
            txtItemId1.Size = new Size(115, 23);
            txtItemId1.TabIndex = 6;
            // 
            // lbItem1
            // 
            lbItem1.AutoSize = true;
            lbItem1.Location = new Point(12, 167);
            lbItem1.Name = "lbItem1";
            lbItem1.Size = new Size(43, 15);
            lbItem1.TabIndex = 49;
            lbItem1.Text = "Item 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 47);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 46;
            label6.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(12, 92);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
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
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(330, 43);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(842, 606);
            dgvPedidos.TabIndex = 27;
            dgvPedidos.TabStop = false;
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
            btnConsultarItemId1.Click += btnConsultarItemId1_Click;
            // 
            // lbQuantidadeItem1
            // 
            lbQuantidadeItem1.AutoSize = true;
            lbQuantidadeItem1.Location = new Point(12, 250);
            lbQuantidadeItem1.MinimumSize = new Size(172, 0);
            lbQuantidadeItem1.Name = "lbQuantidadeItem1";
            lbQuantidadeItem1.Size = new Size(172, 15);
            lbQuantidadeItem1.TabIndex = 60;
            lbQuantidadeItem1.Text = "Quantidade";
            lbQuantidadeItem1.TextAlign = ContentAlignment.MiddleCenter;
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
            txtQtdItem1.TextAlign = HorizontalAlignment.Center;
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
            btnMaisItem1.Click += btnMaisItem1_Click;
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
            btnMenosItem1.Click += btnMenosItem1_Click;
            // 
            // lbTotalItem1
            // 
            lbTotalItem1.AutoSize = true;
            lbTotalItem1.Location = new Point(191, 251);
            lbTotalItem1.MinimumSize = new Size(99, 0);
            lbTotalItem1.Name = "lbTotalItem1";
            lbTotalItem1.Size = new Size(99, 15);
            lbTotalItem1.TabIndex = 64;
            lbTotalItem1.Text = "Total Item 1";
            lbTotalItem1.TextAlign = ContentAlignment.MiddleCenter;
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
            txtTotalItem1.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTotalItem2
            // 
            lbTotalItem2.AutoSize = true;
            lbTotalItem2.Location = new Point(191, 387);
            lbTotalItem2.MinimumSize = new Size(99, 0);
            lbTotalItem2.Name = "lbTotalItem2";
            lbTotalItem2.Size = new Size(99, 15);
            lbTotalItem2.TabIndex = 76;
            lbTotalItem2.Text = "Total Item 2";
            lbTotalItem2.TextAlign = ContentAlignment.MiddleCenter;
            lbTotalItem2.Visible = false;
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
            txtTotalItem2.TextAlign = HorizontalAlignment.Center;
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
            btnMenosItem2.Click += btnMenosItem2_Click;
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
            btnMaisItem2.Click += btnMaisItem2_Click;
            // 
            // lbQuantidadeItem2
            // 
            lbQuantidadeItem2.AutoSize = true;
            lbQuantidadeItem2.Location = new Point(12, 386);
            lbQuantidadeItem2.MinimumSize = new Size(172, 0);
            lbQuantidadeItem2.Name = "lbQuantidadeItem2";
            lbQuantidadeItem2.Size = new Size(172, 15);
            lbQuantidadeItem2.TabIndex = 74;
            lbQuantidadeItem2.Text = "Quantidade";
            lbQuantidadeItem2.TextAlign = ContentAlignment.MiddleCenter;
            lbQuantidadeItem2.Visible = false;
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
            txtQtdItem2.TextAlign = HorizontalAlignment.Center;
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
            btnConsultarItemId2.Click += btnConsultarItemId2_Click;
            // 
            // lbNomeItem2
            // 
            lbNomeItem2.AutoSize = true;
            lbNomeItem2.Location = new Point(12, 357);
            lbNomeItem2.Name = "lbNomeItem2";
            lbNomeItem2.Size = new Size(70, 15);
            lbNomeItem2.TabIndex = 72;
            lbNomeItem2.Text = "Nome item:";
            lbNomeItem2.Visible = false;
            // 
            // txtItemNome2
            // 
            txtItemNome2.BackColor = SystemColors.Window;
            txtItemNome2.Location = new Point(95, 354);
            txtItemNome2.Name = "txtItemNome2";
            txtItemNome2.ReadOnly = true;
            txtItemNome2.Size = new Size(195, 23);
            txtItemNome2.TabIndex = 13;
            txtItemNome2.Visible = false;
            // 
            // lbItemId2
            // 
            lbItemId2.AutoSize = true;
            lbItemId2.Location = new Point(12, 328);
            lbItemId2.Name = "lbItemId2";
            lbItemId2.Size = new Size(77, 15);
            lbItemId2.TabIndex = 71;
            lbItemId2.Text = "Identificador:";
            lbItemId2.Visible = false;
            // 
            // txtItemId2
            // 
            txtItemId2.Location = new Point(95, 325);
            txtItemId2.Name = "txtItemId2";
            txtItemId2.Size = new Size(115, 23);
            txtItemId2.TabIndex = 11;
            txtItemId2.Visible = false;
            // 
            // lbItem2
            // 
            lbItem2.AutoSize = true;
            lbItem2.Location = new Point(12, 303);
            lbItem2.Name = "lbItem2";
            lbItem2.Size = new Size(43, 15);
            lbItem2.TabIndex = 70;
            lbItem2.Text = "Item 2:";
            lbItem2.Visible = false;
            // 
            // lbTotalItem3
            // 
            lbTotalItem3.AutoSize = true;
            lbTotalItem3.Location = new Point(191, 519);
            lbTotalItem3.MinimumSize = new Size(99, 0);
            lbTotalItem3.Name = "lbTotalItem3";
            lbTotalItem3.Size = new Size(99, 15);
            lbTotalItem3.TabIndex = 88;
            lbTotalItem3.Text = "Total Item 3";
            lbTotalItem3.TextAlign = ContentAlignment.MiddleCenter;
            lbTotalItem3.Visible = false;
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
            txtTotalItem3.TextAlign = HorizontalAlignment.Center;
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
            btnMenosItem3.Click += btnMenosItem3_Click;
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
            btnMaisItem3.Click += btnMaisItem3_Click;
            // 
            // lbQuantidadeItem3
            // 
            lbQuantidadeItem3.AutoSize = true;
            lbQuantidadeItem3.Location = new Point(12, 518);
            lbQuantidadeItem3.MinimumSize = new Size(172, 0);
            lbQuantidadeItem3.Name = "lbQuantidadeItem3";
            lbQuantidadeItem3.Size = new Size(172, 15);
            lbQuantidadeItem3.TabIndex = 86;
            lbQuantidadeItem3.Text = "Quantidade";
            lbQuantidadeItem3.TextAlign = ContentAlignment.MiddleCenter;
            lbQuantidadeItem3.Visible = false;
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
            txtQtdItem3.TextAlign = HorizontalAlignment.Center;
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
            btnConsultarItemId3.Click += btnConsultarItemId3_Click;
            // 
            // lbNomeItem3
            // 
            lbNomeItem3.AutoSize = true;
            lbNomeItem3.Location = new Point(12, 489);
            lbNomeItem3.Name = "lbNomeItem3";
            lbNomeItem3.Size = new Size(70, 15);
            lbNomeItem3.TabIndex = 84;
            lbNomeItem3.Text = "Nome item:";
            lbNomeItem3.Visible = false;
            // 
            // txtItemNome3
            // 
            txtItemNome3.BackColor = SystemColors.Window;
            txtItemNome3.Location = new Point(95, 486);
            txtItemNome3.Name = "txtItemNome3";
            txtItemNome3.ReadOnly = true;
            txtItemNome3.Size = new Size(195, 23);
            txtItemNome3.TabIndex = 18;
            txtItemNome3.Visible = false;
            // 
            // lbItemId3
            // 
            lbItemId3.AutoSize = true;
            lbItemId3.Location = new Point(12, 460);
            lbItemId3.Name = "lbItemId3";
            lbItemId3.Size = new Size(77, 15);
            lbItemId3.TabIndex = 83;
            lbItemId3.Text = "Identificador:";
            lbItemId3.Visible = false;
            // 
            // txtItemId3
            // 
            txtItemId3.Location = new Point(95, 457);
            txtItemId3.Name = "txtItemId3";
            txtItemId3.Size = new Size(115, 23);
            txtItemId3.TabIndex = 16;
            txtItemId3.Visible = false;
            // 
            // lbItem3
            // 
            lbItem3.AutoSize = true;
            lbItem3.Location = new Point(12, 435);
            lbItem3.Name = "lbItem3";
            lbItem3.Size = new Size(43, 15);
            lbItem3.TabIndex = 82;
            lbItem3.Text = "Item 3:";
            lbItem3.Visible = false;
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
            rad1.CheckedChanged += rad1_CheckedChanged;
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
            rad2.CheckedChanged += rad2_CheckedChanged;
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
            rad3.CheckedChanged += rad3_CheckedChanged;
            // 
            // txtIdRegistro
            // 
            txtIdRegistro.BackColor = SystemColors.Window;
            txtIdRegistro.Location = new Point(101, 14);
            txtIdRegistro.Name = "txtIdRegistro";
            txtIdRegistro.Size = new Size(189, 23);
            txtIdRegistro.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 17);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 92;
            label4.Text = "Id do Registro:";
            // 
            // formCadPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(label4);
            Controls.Add(txtIdRegistro);
            Controls.Add(rad3);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Controls.Add(label20);
            Controls.Add(radio1);
            Controls.Add(lbTotalItem3);
            Controls.Add(txtTotalItem3);
            Controls.Add(btnMenosItem3);
            Controls.Add(btnMaisItem3);
            Controls.Add(lbQuantidadeItem3);
            Controls.Add(txtQtdItem3);
            Controls.Add(btnConsultarItemId3);
            Controls.Add(lbNomeItem3);
            Controls.Add(txtItemNome3);
            Controls.Add(lbItemId3);
            Controls.Add(txtItemId3);
            Controls.Add(lbItem3);
            Controls.Add(lbTotalItem2);
            Controls.Add(txtTotalItem2);
            Controls.Add(btnMenosItem2);
            Controls.Add(btnMaisItem2);
            Controls.Add(lbQuantidadeItem2);
            Controls.Add(txtQtdItem2);
            Controls.Add(btnConsultarItemId2);
            Controls.Add(lbNomeItem2);
            Controls.Add(txtItemNome2);
            Controls.Add(lbItemId2);
            Controls.Add(txtItemId2);
            Controls.Add(lbItem2);
            Controls.Add(lbTotalItem1);
            Controls.Add(txtTotalItem1);
            Controls.Add(btnMenosItem1);
            Controls.Add(btnMaisItem1);
            Controls.Add(lbQuantidadeItem1);
            Controls.Add(txtQtdItem1);
            Controls.Add(btnConsultarItemId1);
            Controls.Add(lbPreco);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(btnConsultarCpf);
            Controls.Add(btnLimpar);
            Controls.Add(btnRegistrar);
            Controls.Add(lbNomeItem1);
            Controls.Add(txtItemNome1);
            Controls.Add(lbItemId1);
            Controls.Add(txtItemId1);
            Controls.Add(lbItem1);
            Controls.Add(label6);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(btnExcluir);
            Controls.Add(btnRecarregar);
            Controls.Add(label1);
            Controls.Add(dgvPedidos);
            Name = "formCadPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Cadastro de Pedidos";
            Load += formCadPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCep;
        private MaskedTextBox txtCpf;
        private Button btnConsultarCpf;
        private Button btnLimpar;
        private Button btnRegistrar;
        private Label lbNomeItem1;
        private TextBox txtItemNome1;
        private Label lbItemId1;
        private TextBox txtItemId1;
        private Label lbItem1;
        private Label label6;
        private TextBox txtEmail;
        private Label lbQuantidadeItem1;
        private TextBox txtNome;
        private Label label2;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnRecarregar;
        private Label label1;
        private DataGridView dgvPedidos;
        private Label label3;
        private Label lbPreco;
        private Button btnConsultarItemId1;
        private TextBox txtQtdItem1;
        private Button btnMaisItem1;
        private Button btnMenosItem1;
        private Label lbTotalItem1;
        private TextBox txtTotalItem1;
        private Label lbTotalItem2;
        private TextBox txtTotalItem2;
        private Button btnMenosItem2;
        private Button btnMaisItem2;
        private Label lbQuantidadeItem2;
        private TextBox txtQtdItem2;
        private Button btnConsultarItemId2;
        private Label lbNomeItem2;
        private TextBox txtItemNome2;
        private Label lbItemId2;
        private TextBox txtItemId2;
        private Label lbItem2;
        private Label lbTotalItem3;
        private TextBox txtTotalItem3;
        private Button btnMenosItem3;
        private Button btnMaisItem3;
        private Label lbQuantidadeItem3;
        private TextBox txtQtdItem3;
        private Button btnConsultarItemId3;
        private Label lbNomeItem3;
        private TextBox txtItemNome3;
        private Label lbItemId3;
        private TextBox txtItemId3;
        private Label lbItem3;
        private RadioButton radio1;
        private Label label20;
        private RadioButton rad1;
        private RadioButton rad2;
        private RadioButton rad3;
        private TextBox txtIdRegistro;
        private Label label4;
    }
}