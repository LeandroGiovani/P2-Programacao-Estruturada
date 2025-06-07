using projetoP2.Forms;
using projetoP2.Utils;
using System.Data;

namespace projetoP2
{
    public partial class formLogin : Form
    {
        private string[] cabecalhoCsv = { "Nome", "Senha" };

        public formLogin()
        {
            InitializeComponent();
            CsvFuncs.InicializarCsv(CsvFuncs.usuariosCsv, cabecalhoCsv);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable tabelaLogin = CsvFuncs.CarregarCsv(CsvFuncs.usuariosCsv);

            foreach (DataRow row in tabelaLogin.Rows)
            {
                if (row["Nome"].ToString() == nome && row["Senha"].ToString() == senha)
                {
                    if (nome == "ADMIN")
                    {
                        Sessao.UsuarioLogado = "ADMIN";
                        Sessao.SenhaUsuario = senha;
                    }
                    else
                    {
                        Sessao.UsuarioLogado = nome;
                        Sessao.SenhaUsuario = senha;
                    }
                    Form formPrincipal = new formPrincipal();
                    formPrincipal.Show();
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    return;
                }
            }

            MessageBox.Show("Nome ou senha incorretos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }
}
