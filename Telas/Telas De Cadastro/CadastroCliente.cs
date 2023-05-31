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
            userControlEnderecoClientes.maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;

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

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
                if (userControlEnderecoClientes.maskedTextBoxCep.Text.Trim().Length <= 0)
                {
                    return;
                }
                var endereco = new Endereco
                {
                    Cep = userControlEnderecoClientes.maskedTextBoxCep.Text.Trim(),
                };
                try
                {
                    // chama o método para buscar todos os dados da nossa camada model
                    DataTable linhas = enderecoDAO.Buscar(endereco);
                    // seta os dados na tela
                    //userControlEnderecoClientes.TextBoxIdEndereco; =  "";
                    userControlEnderecoClientes.maskedTextBoxCep.Text = "";
                    userControlEnderecoClientes.TextBoxLogradouro.Text = "";
                    userControlEnderecoClientes.TextBoxBairro.Text = "";
                    userControlEnderecoClientes.TextBoxCidade.Text = "";
                    userControlEnderecoClientes.comboBoxUF.Text = "";
                    userControlEnderecoClientes.TextBoxPais.Text = "";
                    foreach (DataRow row in linhas.Rows)
                    {
                        //userControlEnderecoClientes.TextBoxIdEndereco.Text = row["id"].ToString(); ;
                        userControlEnderecoClientes.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                        userControlEnderecoClientes.TextBoxLogradouro.Text = row["logradouro"].ToString(); ;
                        userControlEnderecoClientes.TextBoxBairro.Text = row["bairro"].ToString(); ;
                        userControlEnderecoClientes.TextBoxCidade.Text = row["cidade"].ToString(); ;
                        userControlEnderecoClientes.comboBoxUF.Text = row["uf"].ToString(); ;
                        userControlEnderecoClientes.TextBoxPais.Text = row["pais"].ToString(); ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}