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
            btnLimpar.Enabled = false;
            edicaoIndex = -1;
            btnSalvar.Text = "Cadastrar Usuário";
            LimparCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void formCadUsuarios_Load(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvUsuarios, CsvFuncs.usuariosCsv);

            lbBemVindo.Text = $"Bem-vindo, {Sessao.UsuarioLogado}";
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            txtAlterarSenha.Enabled = false;
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvUsuarios, CsvFuncs.usuariosCsv);
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
                DesabilitarCampos();
                txtNome.Enabled = true;
                txtSenha.Enabled = true;
                btnSalvar.Enabled = true;
                btnLimpar.Enabled = true;
                btnSalvar.Text = "Cadastrar Usuário";
                txtNome.Focus();
            }
        }

        private void atualizarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            edicaoIndex = dgvUsuarios.CurrentCell.RowIndex;

            if (edicaoIndex == -1)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSalvar.Text = "Atualizar Usuário";

            if (dgvUsuarios.Rows[edicaoIndex].Cells[0].Value.ToString() == "ADMIN" && Sessao.UsuarioLogado != "ADMIN")
            {
                MessageBox.Show("Você não pode editar o usuário ADMIN.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (dgvUsuarios.Rows[edicaoIndex].Cells[0].Value.ToString() == Sessao.UsuarioLogado)
            {
                txtNome.Text = dgvUsuarios.Rows[edicaoIndex].Cells[0].Value.ToString();
                txtNome.Enabled = false;
                txtSenha.Text = dgvUsuarios.Rows[edicaoIndex].Cells[1].Value.ToString();
            }

            txtNome.Text = dgvUsuarios.Rows[edicaoIndex].Cells[0].Value.ToString();
            txtSenha.Text = dgvUsuarios.Rows[edicaoIndex].Cells[1].Value.ToString();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string btnText = btnSalvar.Text;

            switch (btnText)
            {
                case "Cadastrar Usuário":
                    if (Sessao.EhAdmin() == true)
                    {
                        CrudFuncs.CriarOuEditarRegistro(dgvUsuarios, CsvFuncs.usuariosCsv, new string[] { txtNome.Text, txtSenha.Text }, edicaoIndex, 0);
                        DesabilitarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Apenas o usuário ADMIN pode cadastrar ou excluir usuários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    break;
                case "Atualizar Usuário":
                    if (edicaoIndex == -1)
                    {
                        MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    CrudFuncs.CriarOuEditarRegistro(dgvUsuarios, CsvFuncs.usuariosCsv, new string[] { txtNome.Text, txtSenha.Text }, edicaoIndex, 0);
                    DesabilitarCampos();
                    break;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Sessao.EhAdmin() == true)
            {
                int index = dgvUsuarios.CurrentCell.RowIndex;

                if (index == -1)
                {
                    MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CrudFuncs.ExcluirRegistro(dgvUsuarios, CsvFuncs.usuariosCsv, index);
                DesabilitarCampos();
                return;
            }
            else
            {
                MessageBox.Show("Apenas o usuário ADMIN pode cadastrar ou excluir usuários.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if (btnAlterarSenha.Text == "Alterar Senha")
            {
                txtAlterarSenha.Enabled = true;
                txtAlterarSenha.Text = Sessao.SenhaUsuario;
                txtAlterarSenha.Focus();
                btnAlterarSenha.Text = "Salvar Nova Senha";
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtAlterarSenha.Text))
                {
                    MessageBox.Show("Por favor, preencha o campo de senha.", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dgvUsuarios.Rows)
                {
                    if (row.Cells[0].Value.ToString() == Sessao.UsuarioLogado)
                    {
                        if (row.Cells[1].Value.ToString() == txtAlterarSenha.Text)
                        {
                            MessageBox.Show("A nova senha não pode ser igual à senha atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        row.Cells[1].Value = txtAlterarSenha.Text;
                        Sessao.SenhaUsuario = txtAlterarSenha.Text;

                        CrudFuncs.CriarOuEditarRegistro(dgvUsuarios, CsvFuncs.usuariosCsv, new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString() }, row.Index, 0);

                        btnAlterarSenha.Text = "Alterar Senha";
                        txtAlterarSenha.Enabled = false;
                        txtAlterarSenha.Text = string.Empty;
                        break;
                    }
                }
            }
        }
    }
}
