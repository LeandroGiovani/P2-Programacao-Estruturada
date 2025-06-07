using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoP2.Utils
{
    public static class CrudFuncs
    {
        public static void AtualizarDataGrid(DataGridView dgv, string caminhoCsv)
        {
            try
            {
                DataTable tabela = CsvFuncs.CarregarCsv(caminhoCsv);
                dgv.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarOuEditarRegistro(DataGridView dgv, string caminhoCsv, string[] dados, int indexEdicao = -1, int indiceCampoUnico = -1)
        {
            if (dados.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            if (indexEdicao == -1)
            {
                if (indiceCampoUnico != -1 && linhas.Skip(1).Any(l => l.Split(',')[indiceCampoUnico] == dados[indiceCampoUnico]))
                {
                    MessageBox.Show("Já existe um registro com este valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                linhas.Add(string.Join(",", dados));
            }
            else
            {
                if (indiceCampoUnico != -1 &&
                    linhas.Skip(1).Where((linha, i) => i != indexEdicao).Any(l => l.Split(',')[indiceCampoUnico] == dados[indiceCampoUnico]))
                {
                    MessageBox.Show("Já existe um registro com este valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                linhas[indexEdicao + 1] = string.Join(",", dados);
            }

            File.WriteAllLines(caminhoCsv, linhas);
            AtualizarDataGrid(dgv, caminhoCsv);
            MessageBox.Show("Registro salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static void ExcluirRegistro(DataGridView dgv, string caminhoCsv, int index)
        {
            if (index < 0 || index >= dgv.Rows.Count)
            {
                MessageBox.Show("Selecione um registro válido para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var linhas = File.ReadAllLines(caminhoCsv).ToList();

            if (MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                linhas.RemoveAt(index + 1);
                File.WriteAllLines(caminhoCsv, linhas);
                AtualizarDataGrid(dgv, caminhoCsv);
                MessageBox.Show("Registro excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
