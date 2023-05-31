using PizzariaDoZe.Telas;
using PizzariaDoZe_DAO.Endereco;
using System.Configuration;
using System.Data;

namespace PizzariaDoZe
{
    public partial class CadastroCliente : Form
    {

        //--------------------------------------------------------------------------------------
        //Atividade-15
        private EnderecoDAO enderecoDAO; //Criando a instancia da classe model
        private string provider;
        private string strConnection;
        //--------------------------------------------------------------------------------------
        public CadastroCliente()
        {
            InitializeComponent();
            //Atividade 15
            //--------------------------------------------------------------------------------------
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            //Mesma coisa que isso: enderecoDAO = new EnderecoDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO();
            enderecoDAO.Provider = provider;
            enderecoDAO.StringConexao = strConnection;

            //página 20 do slide, nao funciona:
            //userControlEndereco.maskedTextBoxCep.Leave += MaskedTextBoxCep_Leave;

            //--------------------------------------------------------------------------------------




            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            //Ajuste de Foco campo nome
            Textbox_NOME.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox_NOME.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste de Foco campo email
            Textbox_EMAIL.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox_EMAIL.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste de Foco campo cpf
            Maskedbox_CPF.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox_CPF.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste do Foco campo telefone
            Maskedbox_TELEFONE.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox_TELEFONE.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void Btn2_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
                if (userControlEndereco.maskedTextBoxCep.Text.Trim().Length <= 0)
                {
                    return;
                }
                var endereco = new Endereco
                {
                    Cep = userControlEndereco.maskedTextBoxCep.Text.Trim(),
                };
                try
                {
                    // chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = enderecoDAO.Buscar(endereco);
                    // seta os dados na tela
                    userControlEndereco.textBoxId.Text = "";
                    //userControlEndereco.maskedTextBoxCep.Text = "";
                    userControlEndereco.textBoxLogradouro.Text = "";
                    userControlEndereco.textBoxBairro.Text = "";
                    userControlEndereco.textBoxCidade.Text = "";
                    userControlEndereco.comboBoxUF.Text = "";
                    userControlEndereco.textBoxPais.Text = "";
                    foreach (DataRow row in linhas.Rows)
                    {
                        userControlEndereco.textBoxId.Text = row["id"].ToString(); ;
                        userControlEndereco.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                        userControlEndereco.textBoxLogradouro.Text = row["logradouro"].ToString(); ;
                        userControlEndereco.textBoxBairro.Text = row["bairro"].ToString(); ;
                        userControlEndereco.textBoxCidade.Text = row["cidade"].ToString(); ;
                        userControlEndereco.comboBoxUF.Text = row["uf"].ToString(); ;
                        userControlEndereco.textBoxPais.Text = row["pais"].ToString(); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }*/
    }
}