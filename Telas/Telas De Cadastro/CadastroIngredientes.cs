using PizzariaDoZe.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Org.BouncyCastle.Asn1;
using PizzariaDoZe_DAO.Ingredientes;
using System.Security.Cryptography.X509Certificates;

namespace PizzariaDoZe
{
    public partial class CadastroIngredientes : Form
    {
        private IngredienteDAO ingredienteDAO;
        private string provider;
        private string strConnection;
        private readonly IngredienteDAO dao; //No construtor da classe FormMarcas vamos instanciar

        public CadastroIngredientes()
        {
            InitializeComponent();
            provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            ingredienteDAO = new IngredienteDAO();
            ingredienteDAO.Provider = provider;
            ingredienteDAO.StringConexao = strConnection;
            // Cria a instância da classe da model
            dataGridViewDados = new DataGridView(); // Instancie o DataGridView conforme sua necessidade

            dao = new IngredienteDAO();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            crud1.BtnSalvar.Click += BtnSalvar_Click;

            //Ajuste do Foco campo Nome
            ING_NOME_TEXT.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            ING_NOME_TEXT.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void VOLTAR_CAD_INGREDIENTES_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela_Cadastros cad1 = new();
            cad1.Show();

        }

        private void Btn_11_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente(ING_NOME_TEXT.Text);
            var Validador = new ValidadorIngrediente();

            var resultadovalidacao = Validador.Validate(ingrediente);
            if (resultadovalidacao.Errors.Count == 0)
            {
                try
                {
                    // chama o método para inserir da camada model
                    dao.InserirDbProvider(ingrediente);
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string PrimeiroErro = resultadovalidacao.Errors[0].ErrorMessage;
                MessageBox.Show(PrimeiroErro);
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente(ING_NOME_TEXT.Text);
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnListaIngredientes_Click(object sender, EventArgs e)
        {
            ListarIngredientes t7 = new();
            t7.Show();
        }
    }
}
