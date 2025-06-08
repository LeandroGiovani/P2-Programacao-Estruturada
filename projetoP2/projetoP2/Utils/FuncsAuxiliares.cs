using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoP2.Utils
{
    public static class FuncsAuxiliares
    {
        public static bool ValidarCpf(string cpf, string nome)
        {
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string[]? cliente = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.clientesCsv, 1, cpf);
            if (cliente == null || cliente.Length == 0)
            {
                MessageBox.Show("CPF não encontrado. Cadastre o cliente primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cliente[0] != nome || cliente[1] != cpf)
            {
                MessageBox.Show("Nome ou CPF não correspondem ao cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidarItem(TextBox idBox, TextBox nomeBox, TextBox qtdBox, int numero)
        {
            string id = idBox.Text.Trim();
            string nome = nomeBox.Text.Trim();
            string qtd = qtdBox.Text.Trim();

            if (id == "" || nome == "" || qtd == "")
            {
                MessageBox.Show($"Preencha todos os campos do item {numero}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string[]? produto = CrudFuncs.LerRegistroPorCampoUnico(CsvFuncs.produtosCsv, 0, id);
            if (produto == null || produto.Length == 0)
            {
                MessageBox.Show($"Item {numero}: ID não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (produto[1] != nome)
            {
                MessageBox.Show($"Item {numero}: nome não confere com o ID.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool TemItensRepetidos(TextBox txtId1, TextBox txtId2, TextBox txtId3, RadioButton r2, RadioButton r3)
        {
            string id1 = txtId1.Text.Trim();
            string id2 = txtId2.Text.Trim();
            string id3 = txtId3.Text.Trim();

            if (r2.Checked && (id1 == id2 || id1 == id3 || id2 == id3))
                return true;

            if (r3.Checked && id1 == id2)
                return true;

            return false;
        }
    }
}
