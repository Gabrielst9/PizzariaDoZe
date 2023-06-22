using PizzariaDoZe.DAO;
using PizzariaDoZe.Telas;
using PizzariaDoZe_DAO.Cliente;
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
        private ClienteDAO clienteDAO; //Criando a instancia da classe model
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

            userControlEnderecoClientes.maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;

            //Parte Cliente
            // cria a instancia da classe da model

            clienteDAO = new ClienteDAO(provider, strConnection);

            CrudCliente.BtnSalvar.Click += BtnSalvar_Click;
            //--------------------------------------------------------------------------------------
            this.ConfigurarShortCut();
            Funcoes.EventoFocoCampos(this);
        }

        private void Btn2_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Quando occore a saida da MaskedTexBox ele traz os dados completos do Endereço
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                userControlEnderecoClientes.TextBoxIdEndereco.Text = "";
                userControlEnderecoClientes.maskedTextBoxCep.Text = "";
                userControlEnderecoClientes.TextBoxLogradouro.Text = "";
                userControlEnderecoClientes.TextBoxBairro.Text = "";
                userControlEnderecoClientes.TextBoxCidade.Text = "";
                userControlEnderecoClientes.comboBoxUF.Text = "";
                userControlEnderecoClientes.TextBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    userControlEnderecoClientes.TextBoxIdEndereco.Text = row["id"].ToString(); ;
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


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (userControlEnderecoClientes.TextBoxIdEndereco.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }

            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = TextboxNome.Text,
                Cpf = MaskedTextboxCpf.Text,
                Telefone = MaskedTextboxTelefone.Text,
                Email = TextboxEmail.Text,
                EnderecoId = int.Parse(userControlEnderecoClientes.TextBoxIdEndereco.Text),
                Numero = userControlEnderecoClientes.TextBoxNumero.Text,
                Complemento = userControlEnderecoClientes.TextBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}