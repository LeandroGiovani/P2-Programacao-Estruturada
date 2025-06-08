using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoP2.Utils
{
    public static class CsvFuncs
    {
        public static string usuariosCsv = Path.Combine(Application.StartupPath, "..\\..\\..\\CSVs\\Usuarios.csv");
        public static string clientesCsv = Path.Combine(Application.StartupPath, "..\\..\\..\\CSVs\\Clientes.csv");
        public static string produtosCsv = Path.Combine(Application.StartupPath, "..\\..\\..\\CSVs\\Produtos.csv");
        public static string pedidosCsv = Path.Combine(Application.StartupPath, "..\\..\\..\\CSVs\\Pedidos.csv");

        public static void InicializarCsv(string caminhoCsv, string[] cabecalho)
        {
            if (!File.Exists(caminhoCsv))
            {
                using (StreamWriter sw = File.CreateText(caminhoCsv))
                {
                    sw.WriteLine(string.Join(",", cabecalho));
                }
            }
        }

        public static DataTable CarregarCsv(string caminhoCsv)
        {
            DataTable tabela = new DataTable();

            try
            {
                string[] linhas = File.ReadAllLines(caminhoCsv);

                if (linhas.Length > 0)
                {
                    string[] cabecalho = linhas[0].Split(',');

                    foreach (string coluna in cabecalho)
                    {
                        tabela.Columns.Add(coluna);
                    }

                    for (int i = 1; i < linhas.Length; i++)
                    {
                        string[] dados = linhas[i].Split(',');
                        tabela.Rows.Add(dados);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar o arquivo CSV: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tabela;
        }
    }
}
