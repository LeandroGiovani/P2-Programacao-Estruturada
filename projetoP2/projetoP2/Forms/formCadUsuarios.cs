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
    public partial class formCadUsuarios : Form
    {
        private int edicaoIndex = -1;

        public formCadUsuarios()
        {
            InitializeComponent();
        }

        private void AtualizarDataGrid()
        {
            DataTable usuarios = CsvFuncs.CarregarCsv(CsvFuncs.usuariosCsv);
            dgvUsuarios.DataSource = usuarios;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtSenha.Clear();
        }

        private void formCadUsuarios_Load(object sender, EventArgs e)
        {
            AtualizarDataGrid();

            lbBemVindo.Text = $"Bem-vindo, {Sessao.UsuarioLogado}";
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            AtualizarDataGrid();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Sessao.EhAdmin())
            {
                MessageBox.Show("Apenas o usuário ADMIN pode cadastrar ou excluir usuários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                txtNome.Enabled = true;
                txtSenha.Enabled = true;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Cadastrar Usuário";
                txtNome.Focus();
            }
        }

        private void atualizarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarUsuario()
        {
            return;
        }

        private void AtualizarUsuario()
        {
            return;
        }

        private void ExcluirUsuario()
        {
            return;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string btnText = btnSalvar.Text;

            switch (btnText)
            {
                case "Cadastrar Usuário":
                    CadastrarUsuario();
                    break;
                case "Atualizar Usuário":
                    AtualizarUsuario();
                    break;
                case "Excluir Usuário":
                    ExcluirUsuario();
                    break;
            }
        }

    }
}
