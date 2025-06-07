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
        public formCadProdutos()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.produtosCsv, new string[] { "Nome do Produto", "Preço", "Descrição" });
        }

        private void formCadProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
