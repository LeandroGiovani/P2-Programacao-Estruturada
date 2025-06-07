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
        private int edicaoIndex = -1;

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
                string cep = txtCep.Text.Trim().Replace(".", "").Replace("-", "");
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

        private void LimparCampos()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();
            txtWhatsApp.Clear();
            edicaoIndex = -1;
            btnRegistrar.Text = "Registrar Cliente";
        }

        private void formCadClientes_Load(object sender, EventArgs e)
        {
            CrudFuncs.AtualizarDataGrid(dgvClientes, CsvFuncs.clientesCsv);
        }

        private async void btnConsultarCep_Click(object sender, EventArgs e)
        {
            await getCep();
            txtNumero.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string endereco = $"{txtCep.Text.Trim()} - {txtLogradouro.Text.Trim()} - {txtNumero.Text.Trim()} - {txtBairro.Text.Trim()} - {txtCidade.Text.Trim()} - {txtEstado.Text.Trim()}";

            if (btnRegistrar.Text == "Registrar Cliente")
            {
                edicaoIndex = -1;

                CrudFuncs.CriarOuEditarRegistro(
                dgvClientes,
                CsvFuncs.clientesCsv,
                new string[]
                {
                    txtNome.Text,
                    txtCpf.Text,
                    txtEmail.Text,
                    endereco,
                    txtTelefone.Text,
                    txtWhatsApp.Text
                },
                edicaoIndex,
                1
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
                    dgvClientes,
                    CsvFuncs.clientesCsv,
                    new string[]
                    {
                        txtNome.Text,
                        txtCpf.Text,
                        txtEmail.Text,
                        endereco,
                        txtTelefone.Text,
                        txtWhatsApp.Text
                    },
                    edicaoIndex,
                    1
                );

                LimparCampos();
                btnRegistrar.Text = "Registrar Cliente";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            edicaoIndex = dgvClientes.CurrentCell.RowIndex;

            if (edicaoIndex == -1)
            {
                MessageBox.Show("Selecione um usuário para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var valorCelula = dgvClientes.Rows[edicaoIndex].Cells[3].Value;

            if (valorCelula == null)
            {
                MessageBox.Show("O campo de endereço está vazio ou inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] enderecoArray = valorCelula.ToString()!.Split(" - ");

            txtNome.Text = dgvClientes.Rows[edicaoIndex].Cells[0].Value.ToString();
            txtCpf.Text = dgvClientes.Rows[edicaoIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvClientes.Rows[edicaoIndex].Cells[2].Value.ToString();
            txtCep.Text = enderecoArray[0].Replace("-", "").Replace(".", "");
            txtLogradouro.Text = enderecoArray[1];
            txtNumero.Text = enderecoArray[2];
            txtBairro.Text = enderecoArray[3];
            txtCidade.Text = enderecoArray[4];
            txtEstado.Text = enderecoArray[5];
            txtTelefone.Text = dgvClientes.Rows[edicaoIndex].Cells[4].Value.ToString();
            txtWhatsApp.Text = dgvClientes.Rows[edicaoIndex].Cells[5].Value.ToString();

            btnRegistrar.Text = "Atualizar Cliente";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            edicaoIndex = dgvClientes.CurrentCell.RowIndex;

            if (edicaoIndex == -1)
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CrudFuncs.ExcluirRegistro(dgvClientes, CsvFuncs.clientesCsv, edicaoIndex);
        }
    }   
}
