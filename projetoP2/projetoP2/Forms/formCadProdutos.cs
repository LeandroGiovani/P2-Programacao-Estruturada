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
using static projetoP2.Forms.formCadClientes;

namespace projetoP2.Forms
{
    public partial class formCadProdutos : Form
    {
        private int edicaoIndex = -1;

        public formCadProdutos()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.produtosCsv, new string[] { "Nome do Produto", "Preço", "Descrição" });
        }

        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtDescricao.Clear();
            edicaoIndex = -1;
            btnRegistrar.Text = "Registrar Produto";
        }

        private void formCadProdutos_Load(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvProdutos, CsvFuncs.produtosCsv);
        }

        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvProdutos, CsvFuncs.produtosCsv);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (btnRegistrar.Text == "Registrar Produto")
            {
                edicaoIndex = -1;

                CrudFuncs.CriarOuEditarRegistro(
                    dgvProdutos,
                    CsvFuncs.produtosCsv,
                    new string[] { txtNomeProduto.Text, $"R$ {txtPreco.Text.Trim().Replace("R$", "").Replace(" ", "").Replace(",", ".")}", txtDescricao.Text },
                    edicaoIndex,
                    0
                );

                LimparCampos();
            }
            else
            {
                if (edicaoIndex == -1)
                {
                    MessageBox.Show("Selecione um cliente para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CrudFuncs.CriarOuEditarRegistro(
                    dgvProdutos,
                    CsvFuncs.produtosCsv,
                    new string[]
                    {
                        txtNomeProduto.Text,
                        $"R$ {txtPreco.Text.Trim().Replace("R$", "").Replace(" ", "").Replace(",", ".")}",
                        txtDescricao.Text
                    },
                    edicaoIndex,
                    0
                );

                LimparCampos();
                btnRegistrar.Text = "Registrar Cliente";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            edicaoIndex = dgvProdutos.CurrentCell.RowIndex;

            if (edicaoIndex == -1)
            {
                MessageBox.Show("Selecione um produto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valorProduto = dgvProdutos.Rows[edicaoIndex].Cells[1].Value.ToString();

            if (valorProduto == null)
            {
                MessageBox.Show("O campo de preço está vazio ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtNomeProduto.Text = dgvProdutos.Rows[edicaoIndex].Cells[0].Value.ToString();
            txtPreco.Text = valorProduto.Replace("R$", "").Replace(" ", "");
            txtDescricao.Text = dgvProdutos.Rows[edicaoIndex].Cells[2].Value.ToString();

            btnRegistrar.Text = "Atualizar Produto";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            edicaoIndex = dgvProdutos.CurrentCell.RowIndex;

            if (edicaoIndex == -1)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CrudFuncs.ExcluirRegistro(dgvProdutos, CsvFuncs.produtosCsv, edicaoIndex);
        }
    }
}
