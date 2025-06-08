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
    public partial class formCadPedidos : Form
    {
        private int exclusaoIndex = -1;

        public formCadPedidos()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.pedidosCsv, new string[] { "ID Registro", "CPF Cliente", "Itens do Pedido", "Preço Total" });
        }

        private void LimparCampos(int totalItens = 3)
        {
            txtIdRegistro.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;

            for (int i = 1; i <= totalItens; i++)
            {
                var txtItemId = Controls.Find($"txtItemId{i}", true).FirstOrDefault() as TextBox;
                var txtItemNome = Controls.Find($"txtItemNome{i}", true).FirstOrDefault() as TextBox;
                var txtQtdItem = Controls.Find($"txtQtdItem{i}", true).FirstOrDefault() as TextBox;
                var txtTotalItem = Controls.Find($"txtTotalItem{i}", true).FirstOrDefault() as TextBox;

                if (txtItemId != null) txtItemId.Text = string.Empty;
                if (txtItemNome != null) txtItemNome.Text = string.Empty;
                if (txtQtdItem != null) txtQtdItem.Text = string.Empty;
                if (txtTotalItem != null)
                {
                    txtTotalItem.Text = string.Empty;
                    txtTotalItem.Tag = null;
                }
            }

            lbPreco.Text = "0.00";
            RecalcularValores();
        }


        private void AcionarItemInputs(int qtd)
        {
            Control[] item2Controls = new Control[]
            {
                lbItem2, lbItemId2, txtItemId2, btnConsultarItemId2,
                lbNomeItem2, txtItemNome2, lbQuantidadeItem2, lbTotalItem2,
                btnMenosItem2, txtQtdItem2, btnMaisItem2, txtTotalItem2
            };

            Control[] item3Controls = new Control[]
            {
                lbItem3, lbItemId3, txtItemId3, btnConsultarItemId3,
                lbNomeItem3, txtItemNome3, lbQuantidadeItem3, lbTotalItem3,
                btnMenosItem3, txtQtdItem3, btnMaisItem3, txtTotalItem3
            };

            SetVisibilidadeControles(item2Controls, qtd >= 2);
            SetVisibilidadeControles(item3Controls, qtd == 3);
        }

        private void SetVisibilidadeControles(Control[] controles, bool visibilidade)
        {
            foreach (var controle in controles)
            {
                controle.Visible = visibilidade;
            }
        }

        private void AlterarQuantidade(string operador, int itemNumero)
        {
            TextBox? txtItemNome = Controls.Find($"txtItemNome{itemNumero}", true).First() as TextBox;

            if (txtItemNome == null || string.IsNullOrWhiteSpace(txtItemNome.Text))
            {
                MessageBox.Show("Por favor, informe o ID do item antes de alterar a quantidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TextBox? txtQtdItem = Controls.Find($"txtQtdItem{itemNumero}", true).First() as TextBox;
            int.TryParse(txtQtdItem?.Text, out int qtdAtual);

            if (txtQtdItem == null)
            {
                MessageBox.Show("Quantidade inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (operador)
            {
                case "+":
                    qtdAtual++;
                    break;
                case "-":
                    if (qtdAtual > 1)
                        qtdAtual--;
                    break;
            }

            txtQtdItem.Text = qtdAtual.ToString();

            RecalcularValores();
        }

        private void ConsultarItemPorId(int itemNumero)
        {
            var txtItemId = Controls.Find($"txtItemId{itemNumero}", true).FirstOrDefault() as TextBox;
            var txtItemNome = Controls.Find($"txtItemNome{itemNumero}", true).FirstOrDefault() as TextBox;
            var txtQtdItem = Controls.Find($"txtQtdItem{itemNumero}", true).FirstOrDefault() as TextBox;
            var txtTotalItem = Controls.Find($"txtTotalItem{itemNumero}", true).FirstOrDefault() as TextBox;

            if (txtItemId == null || txtItemNome == null || txtQtdItem == null || txtTotalItem == null)
                return;

            string[]? consultaId = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.produtosCsv, 0, txtItemId.Text.Trim());

            txtItemNome.Text = consultaId?[1] ?? string.Empty;

            if (!string.IsNullOrEmpty(txtItemNome.Text))
            {
                txtQtdItem.Text = "1";

                string precoUnit = consultaId?[2].Replace("R$", "").Trim() ?? "0.00";
                txtTotalItem.Tag = precoUnit;
                txtTotalItem.Text = precoUnit;
            }

            RecalcularValores();
        }


        private void RecalcularValores()
        {
            decimal totalPedido = 0;

            for (int i = 1; i <= 3; i++)
            {
                var txtQtd = Controls.Find($"txtQtdItem{i}", true).FirstOrDefault() as TextBox;
                var txtTotal = Controls.Find($"txtTotalItem{i}", true).FirstOrDefault() as TextBox;
                var txtItemId = Controls.Find($"txtItemId{i}", true).FirstOrDefault() as TextBox;

                if (txtQtd != null && txtTotal != null && !string.IsNullOrWhiteSpace(txtItemId?.Text))
                {
                    string precoUnitStr = txtTotal.Tag?.ToString() ?? "0";

                    if (decimal.TryParse(precoUnitStr, out decimal precoUnitario) &&
                        int.TryParse(txtQtd.Text, out int quantidade))
                    {
                        decimal total = precoUnitario * quantidade;
                        totalPedido += total;
                        txtTotal.Text = $"R$ {total.ToString("0.00")}";
                    }
                }
            }

            lbPreco.Text = $"R$ {totalPedido.ToString("0.00")}";
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if (rad1.Checked)
            {
                AcionarItemInputs(1);
            }
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked)
            {
                AcionarItemInputs(2);
            }
        }

        private void rad3_CheckedChanged(object sender, EventArgs e)
        {
            if (rad3.Checked)
            {
                AcionarItemInputs(3);
            }
        }

        private void btnConsultarCpf_Click(object sender, EventArgs e)
        {
            string[]? consultaCpf = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.clientesCsv, 1, txtCpf.Text.Trim());

            txtNome.Text = consultaCpf?[0] ?? string.Empty;
        }

        private void btnConsultarItemId1_Click(object sender, EventArgs e)
        {
            ConsultarItemPorId(1);
        }

        private void btnMenosItem1_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("-", 1);
        }

        private void btnMaisItem1_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("+", 1);
        }

        private void btnConsultarItemId2_Click(object sender, EventArgs e)
        {
            ConsultarItemPorId(2);
        }

        private void btnMenosItem2_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("-", 2);
        }

        private void btnMaisItem2_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("+", 2);
        }

        private void btnConsultarItemId3_Click(object sender, EventArgs e)
        {
            ConsultarItemPorId(3);
        }

        private void btnMenosItem3_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("-", 3);
        }

        private void btnMaisItem3_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("+", 3);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void formCadPedidos_Load(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvPedidos, CsvFuncs.pedidosCsv);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text.Trim();
            string nome = txtNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(lbPreco.Text.Replace("R$", "").Trim(), out decimal precoTotal) || precoTotal <= 0)
            {
                MessageBox.Show("O preço total deve ser um valor válido e maior que zero.", "Preço Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!FuncsAuxiliares.ValidarCpf(cpf, nome)) return;

            if (!FuncsAuxiliares.ValidarItem(txtItemId1, txtItemNome1, txtQtdItem1, 1)) return;

            if (rad2.Checked && !FuncsAuxiliares.ValidarItem(txtItemId2, txtItemNome2, txtQtdItem2, 2)) return;

            if (rad3.Checked)
            {
                if (!FuncsAuxiliares.ValidarItem(txtItemId2, txtItemNome2, txtQtdItem2, 2)) return;
                if (!FuncsAuxiliares.ValidarItem(txtItemId3, txtItemNome3, txtQtdItem3, 3)) return;
            }

            if (FuncsAuxiliares.TemItensRepetidos(txtItemId1, txtItemId2, txtItemId3, rad2, rad3))
            {
                MessageBox.Show("Não é permitido adicionar o mesmo item mais de uma vez.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string itensPedido = $"{txtItemId1.Text} - {txtItemNome1.Text} ({txtQtdItem1.Text})";

            if (rad2.Checked || rad3.Checked)
            {
                itensPedido += $"; {txtItemId2.Text} - {txtItemNome2.Text} ({txtQtdItem2.Text})";
            }

            if (rad3.Checked)
            {
                itensPedido += $"; {txtItemId3.Text} - {txtItemNome3.Text} ({txtQtdItem3.Text})";
            }

            CrudFuncs.CriarOuEditarRegistro(
                dgvPedidos,
                CsvFuncs.pedidosCsv,
                new string[]
                {
                    txtIdRegistro.Text.Trim(),
                    txtCpf.Text.Trim(),
                    itensPedido,
                    $"R$ {precoTotal.ToString()}"
                },
                exclusaoIndex,
                0
            );
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            exclusaoIndex = dgvPedidos.CurrentCell.RowIndex;

            if (exclusaoIndex == -1)
            {
                MessageBox.Show("Selecione um pedido para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CrudFuncs.ExcluirRegistro(dgvPedidos, CsvFuncs.pedidosCsv, exclusaoIndex);
            LimparCampos();
            exclusaoIndex = -1;
        }
    }
}
