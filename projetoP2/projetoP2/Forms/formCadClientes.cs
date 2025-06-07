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
using System.Text.Json;

namespace projetoP2.Forms
{
    public partial class formCadClientes : Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public formCadClientes()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.clientesCsv, new string[] { "Nome", "CPF", "Email", "Endereço", "Telefone", "WhatsApp" });
        }

        public class Endereco
        {
            public string cep { get; set; }

            public string logradouro { get; set; }

            public string bairro { get; set; }

            public string localidade { get; set; }

            public string uf { get; set; }
        }


        private async Task getCep()
        {
            try
            {
                string cep = txtCep.Text.Trim();
                string url = $"https://viacep.com.br/ws/{cep}/json/";

                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Endereco? endereco = JsonSerializer.Deserialize<Endereco>(responseBody);

                if (endereco == null || endereco.cep == null)
                {
                    MessageBox.Show("CEP não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtLogradouro.Text = endereco.logradouro;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.localidade;
                txtEstado.Text = endereco.uf;

                MessageBox.Show("CEP encontrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar o CEP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void formCadClientes_Load(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvClientes, CsvFuncs.clientesCsv);
        }

        private async void btnConsultarCep_Click(object sender, EventArgs e)
        {
            await getCep();
        }
    }
}
