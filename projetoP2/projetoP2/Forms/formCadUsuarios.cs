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

            txtNome.Text = dgvUsuarios.Rows[edicaoIndex].Cells[0].Value.ToString();
            txtSenha.Text = dgvUsuarios.Rows[edicaoIndex].Cells[1].Value.ToString();
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
                    CrudFuncs.CriarOuEditarRegistro(dgvUsuarios, CsvFuncs.usuariosCsv, new string[] { txtNome.Text, txtSenha.Text }, edicaoIndex, 0);
                    DesabilitarCampos();
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
                case "Excluir Usuário":
                    ExcluirUsuario();
                    break;
            }
        }

    }
}
