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
            // Configura colunas (se não estiver feito no Designer)
            lvPedidos.View = View.Details;
            lvPedidos.Columns.Add("ID Pedido", 100);
            lvPedidos.Columns.Add("Data", 100);
            lvPedidos.Columns.Add("Valor Total", 100);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string cpf = txtCpf.Text.Trim();

            string[]? consultaCliente = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.clientesCsv, 1, cpf);
            string[]? pedidos = CrudFuncs.LerLinhasPorCampo(CsvFuncs.pedidosCsv, 1, cpf);

            txtNome.Text = consultaCliente?[0] ?? string.Empty;

            lvPedidos.Items.Clear(); // Limpa a lista antes de preencher

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


    }
}
