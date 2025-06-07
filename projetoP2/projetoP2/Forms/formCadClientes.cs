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
    public partial class formCadClientes : Form
    {
        public formCadClientes()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.clientesCsv, new string[] { "Nome", "CPF", "Email", "Endereço", "Telefone", "WhatsApp" });
        }

        private void formCadClientes_Load(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvClientes, CsvFuncs.clientesCsv);
        }
    }
}
