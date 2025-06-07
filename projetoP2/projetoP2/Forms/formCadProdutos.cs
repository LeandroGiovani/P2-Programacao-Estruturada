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
    }
}
