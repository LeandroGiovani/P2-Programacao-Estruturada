namespace projetoP2.Forms
{
    partial class formPrincipal
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
            cadastroDeClientesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDePedidosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            fecharProgramaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroDeClientesToolStripMenuItem, cadastroDeProdutosToolStripMenuItem, cadastroDePedidosToolStripMenuItem, cadastroDeUsuáriosToolStripMenuItem, sairToolStripMenuItem, fecharProgramaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            cadastroDeClientesToolStripMenuItem.Size = new Size(127, 20);
            cadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes";
            cadastroDeClientesToolStripMenuItem.Click += cadastroDeClientesToolStripMenuItem_Click;
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            cadastroDeProdutosToolStripMenuItem.Size = new Size(133, 20);
            cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            // 
            // cadastroDePedidosToolStripMenuItem
            // 
            cadastroDePedidosToolStripMenuItem.Name = "cadastroDePedidosToolStripMenuItem";
            cadastroDePedidosToolStripMenuItem.Size = new Size(127, 20);
            cadastroDePedidosToolStripMenuItem.Text = "Cadastro de Pedidos";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            cadastroDeUsuáriosToolStripMenuItem.Size = new Size(130, 20);
            cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários";
            cadastroDeUsuáriosToolStripMenuItem.Click += cadastroDeUsuáriosToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // fecharProgramaToolStripMenuItem
            // 
            fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            fecharProgramaToolStripMenuItem.Size = new Size(109, 20);
            fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            fecharProgramaToolStripMenuItem.Click += fecharProgramaToolStripMenuItem_Click;
            // 
            // formPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formPrincipal";
            Text = "Formulário Principal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private ToolStripMenuItem cadastroDePedidosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem fecharProgramaToolStripMenuItem;
    }
}