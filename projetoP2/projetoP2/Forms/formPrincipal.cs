using projetoP2.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoP2.Forms
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fromCadClientes = new formCadClientes();
            fromCadClientes.Show();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCadUsuarios = new formCadUsuarios();
            formCadUsuarios.Show();
        }


        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCadProdutos = new formCadProdutos();
            formCadProdutos.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sessao.UsuarioLogado = "";
                Sessao.SenhaUsuario = "";
                Form formLogin = new formLogin();
                formLogin.Show();
                Close();
            }
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
