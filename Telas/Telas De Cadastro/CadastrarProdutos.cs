using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.ClassEnum;

namespace PizzariaDoZe
{
    public partial class CadastrarProdutos : Form
    {
        private ProdutoDAO produtoDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection =
        ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        public CadastrarProdutos()
        {
            InitializeComponent();

            this.ConfigurarShortCut();
            Funcoes.EventoFocoCampos(this);

            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);

            CarregaEnumListBox();

            CrudProdutos.BtnSalvar.Click += BtnSalvar_Click;
            CrudProdutos.BtnFechar.Click += BtnSair_Click;
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = TextBoxNome.Text,
                Valor = decimal.Parse(TextBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxMl.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }
    }
}
