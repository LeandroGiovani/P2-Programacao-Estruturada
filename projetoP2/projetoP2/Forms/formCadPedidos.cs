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
        public formCadPedidos()
        {
            InitializeComponent();
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
            string[]? consultaId = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.produtosCsv, 0, txtItemId1.Text.Trim());

            txtItemNome1.Text = consultaId?[1] ?? string.Empty;

            if (!string.IsNullOrEmpty(txtItemNome1.Text))
            {
                txtQtdItem1.Text = "1";

                string precoUnit = consultaId?[2].Replace("R$", "").Trim() ?? "0.00";
                txtTotalItem1.Tag = precoUnit;
                txtTotalItem1.Text = precoUnit;
            }

            RecalcularValores();
        }

        private void btnMaisItem1_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("+", 1);
        }

        private void btnMenosItem1_Click(object sender, EventArgs e)
        {
            AlterarQuantidade("-", 1);
        }
    }
}
