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
    public partial class formConsultaPedidos : Form
    {
        public formConsultaPedidos()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.produtosPedidosCsv, new string[] { "Id Pedido", "Id Produto", "Nome Produto", "Quantidade", "Preço Unitário", "Preço Total" });
        }

        private void formConsultaPedidos_Load(object sender, EventArgs e)
        {
            lvPedidos.View = View.Details;
            lvPedidos.Columns.Add("ID Pedido", 100);
            lvPedidos.Columns.Add("CPF Cliente", 100);
            lvPedidos.Columns.Add("Itens", 100);
            lvPedidos.Columns.Add("Valor Total", 100);

            lvConsultaPedido.View = View.Details;
            lvConsultaPedido.Columns.Add("ID Produto", 100);
            lvConsultaPedido.Columns.Add("Nome Produto", 150);
            lvConsultaPedido.Columns.Add("Quantidade", 100);
            lvConsultaPedido.Columns.Add("Preço Unitário", 100);
            lvConsultaPedido.Columns.Add("Preço Total", 100);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            lvConsultaPedido.Items.Clear();
            lbIdPedido.Text = "Identificador do Pedido:";
            lbValorTotal.Text = "Valor Total do Pedido -:";

            string cpf = txtCpf.Text.Trim();

            string[]? consultaCliente = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.clientesCsv, 1, cpf);
            string[]? pedidos = CrudFuncs.LerLinhasPorCampo(CsvFuncs.pedidosCsv, 1, cpf);

            txtNome.Text = consultaCliente?[0] ?? string.Empty;

            lvPedidos.Items.Clear();

            if (pedidos != null && pedidos.Length > 0)
            {
                foreach (string pedido in pedidos)
                {
                    string[] campos = pedido.Split(',');
                    ListViewItem item = new ListViewItem(campos);
                    lvPedidos.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nenhum pedido encontrado para o CPF informado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            lvConsultaPedido.Items.Clear();

            if (lvPedidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um pedido para consultar.", "Seleção de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lvPedidos.SelectedItems[0];

            string idPedido = selectedItem.SubItems[0].Text;
            string cpfCliente = selectedItem.SubItems[1].Text.Replace(".", "").Replace("-", "");
            string valorTotal = selectedItem.SubItems[3].Text;
            string itensString = selectedItem.SubItems[2].Text;
            string[]? itemString = itensString.Split(';');
            string[] itemIdString = itemString.Select(item => item.Split('-')[0].Trim()).ToArray();

            foreach (string itemId in itemIdString)
            {
                string produtoPedidosId = $"{cpfCliente}#{idPedido}#{itemId}";

                string[]? produtoPedido = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.produtosPedidosCsv, 0, produtoPedidosId);

                if (produtoPedido != null && produtoPedido.Length > 0)
                {
                    string idPedidoProduto = produtoPedido[0];
                    string idProduto = produtoPedido[1];
                    string nomeProduto = produtoPedido[2];
                    string quantidade = produtoPedido[3];
                    string precoUnitario = produtoPedido[4];
                    string precoTotal = produtoPedido[5];

                    ListViewItem item = new ListViewItem(new string[]
                    {
                        idProduto,
                        nomeProduto,
                        quantidade,
                        precoUnitario,
                        precoTotal
                    });

                    lvConsultaPedido.Items.Add(item);
                }
            }

            lbIdPedido.Text = $"Identificador do Pedido: {idPedido}";
            lbValorTotal.Text = $"Valor Total do Pedido {idPedido}: R$ {valorTotal}";
        }

        private void btnLimparConsulta_Click(object sender, EventArgs e)
        {
            lvConsultaPedido.Items.Clear();
            lbIdPedido.Text = "Identificador do Pedido:";
            lbValorTotal.Text = $"Valor Total do Pedido -:";
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            txtCpf.Clear();
            txtNome.Clear();
            lvPedidos.Items.Clear();
        }
    }
}
