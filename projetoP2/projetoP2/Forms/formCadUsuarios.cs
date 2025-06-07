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

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            btnSalvar.Enabled = false;
            edicaoIndex = -1;
            btnSalvar.Text = "Cadastrar Usuário";
            LimparCampos();
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
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(CsvFuncs.usuariosCsv).ToList();

            if (edicaoIndex == -1)
            {
                if (linhas.Skip(1).Any(l => l.Split(',')[0] == nome))
                {
                    MessageBox.Show("Usuário já cadastrado com este nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                linhas.Add($"{nome},{senha}");
            }

            File.WriteAllLines(CsvFuncs.usuariosCsv, linhas);
            AtualizarDataGrid();
            DesabilitarCampos();
            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
