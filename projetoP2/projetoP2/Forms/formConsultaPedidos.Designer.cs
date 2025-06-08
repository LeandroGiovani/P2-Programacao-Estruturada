namespace projetoP2.Forms
{
    partial class formConsultaPedidos
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
            lvPedidos = new ListView();
            txtCpf = new MaskedTextBox();
            txtNome = new TextBox();
            btnPesquisar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConsultarPedido = new Button();
            btnLimparConsulta = new Button();
            lbIdPedido = new Label();
            lvConsultaPedido = new ListView();
            SuspendLayout();
            // 
            // lvPedidos
            // 
            lvPedidos.FullRowSelect = true;
            lvPedidos.GridLines = true;
            lvPedidos.HoverSelection = true;
            lvPedidos.Location = new Point(12, 197);
            lvPedidos.MultiSelect = false;
            lvPedidos.Name = "lvPedidos";
            lvPedidos.Size = new Size(355, 452);
            lvPedidos.TabIndex = 0;
            lvPedidos.UseCompatibleStateImageBehavior = false;
            lvPedidos.View = View.Details;
            lvPedidos.SelectedIndexChanged += this.lvPedidos_SelectedIndexChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 69);
            txtCpf.Mask = "999.999.999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(210, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(12, 121);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(355, 23);
            txtNome.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(228, 69);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(139, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 51);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(182, 21);
            label3.TabIndex = 6;
            label3.Text = "Visualização dos Pedidos";
            label3.Click += this.label3_Click;
            // 
            // btnConsultarPedido
            // 
            btnConsultarPedido.Location = new Point(228, 168);
            btnConsultarPedido.Name = "btnConsultarPedido";
            btnConsultarPedido.Size = new Size(139, 23);
            btnConsultarPedido.TabIndex = 7;
            btnConsultarPedido.Text = "Consultar Pedido";
            btnConsultarPedido.UseVisualStyleBackColor = true;
            btnConsultarPedido.Click += btnConsultarPedido_Click;
            // 
            // btnLimparConsulta
            // 
            btnLimparConsulta.Location = new Point(1033, 40);
            btnLimparConsulta.Name = "btnLimparConsulta";
            btnLimparConsulta.Size = new Size(139, 23);
            btnLimparConsulta.TabIndex = 10;
            btnLimparConsulta.Text = "Limpar Consulta";
            btnLimparConsulta.UseVisualStyleBackColor = true;
            // 
            // lbIdPedido
            // 
            lbIdPedido.AutoSize = true;
            lbIdPedido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbIdPedido.Location = new Point(429, 45);
            lbIdPedido.Name = "lbIdPedido";
            lbIdPedido.Size = new Size(173, 21);
            lbIdPedido.TabIndex = 9;
            lbIdPedido.Text = "Identificador do Pedido:";
            // 
            // lvConsultaPedido
            // 
            lvConsultaPedido.FullRowSelect = true;
            lvConsultaPedido.GridLines = true;
            lvConsultaPedido.HoverSelection = true;
            lvConsultaPedido.Location = new Point(429, 69);
            lvConsultaPedido.MultiSelect = false;
            lvConsultaPedido.Name = "lvConsultaPedido";
            lvConsultaPedido.Size = new Size(743, 580);
            lvConsultaPedido.TabIndex = 8;
            lvConsultaPedido.UseCompatibleStateImageBehavior = false;
            lvConsultaPedido.View = View.Details;
            // 
            // formConsultaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(btnLimparConsulta);
            Controls.Add(lbIdPedido);
            Controls.Add(lvConsultaPedido);
            Controls.Add(btnConsultarPedido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPesquisar);
            Controls.Add(txtNome);
            Controls.Add(txtCpf);
            Controls.Add(lvPedidos);
            Name = "formConsultaPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de Consulta de Pedidos";
            Load += formConsultaPedidos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPedidos;
        private MaskedTextBox txtCpf;
        private TextBox txtNome;
        private Button btnPesquisar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConsultarPedido;
        private Button btnLimparConsulta;
        private Label lbIdPedido;
        private ListView lvConsultaPedido;
    }
}