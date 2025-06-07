using projetoP2.Forms;
using projetoP2.Utils;
using System.Data;

namespace projetoP2
{
    public partial class formLogin : Form
    {
        private string caminhoCsv = Path.Combine(Application.StartupPath, "..\\..\\..\\CSVs\\login.csv");
        private string[] cabecalhoCsv = { "Nome", "Senha" };

        public formLogin()
        {
            InitializeComponent();
            csvFuncs.InicializarCsv(caminhoCsv, cabecalhoCsv);
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

            DataTable tabelaLogin = csvFuncs.CarregarCsv(caminhoCsv);

            foreach (DataRow row in tabelaLogin.Rows)
            {
                if (row["Nome"].ToString() == nome && row["Senha"].ToString() == senha)
                {
                    MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form formPrincipal = new formPrincipal();
                    formPrincipal.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Nome ou senha incorretos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
