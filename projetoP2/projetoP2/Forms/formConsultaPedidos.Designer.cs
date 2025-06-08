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
            SuspendLayout();
            // 
            // lvPedidos
            // 
            lvPedidos.Location = new Point(12, 197);
            lvPedidos.Name = "lvPedidos";
            lvPedidos.Size = new Size(1160, 452);
            lvPedidos.TabIndex = 0;
            lvPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 77);
            txtCpf.Mask = "999.999.999-99";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(166, 23);
            txtCpf.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.Window;
            txtNome.Location = new Point(12, 129);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(268, 23);
            txtNome.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(184, 77);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(96, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
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
            // 
            // formConsultaPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
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
    }
}