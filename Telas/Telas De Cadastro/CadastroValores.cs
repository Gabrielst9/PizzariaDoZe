using PizzariaDoZe.DAO;
using PizzariaDoZe_DAO.Sabor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.ClassEnum;

namespace PizzariaDoZe
{
    public partial class CadastroValores : Form
    {

        private ValorDAO valorDAO;
        public CadastroValores()
        {
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            InitializeComponent();
            this.ConfigurarShortCut();

            valorDAO = new ValorDAO(provider, strConnection);
            
            CarregaEnumListBox();

            CrudValores.BtnSalvar.Click += BtnSalvar_Click; 

        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanhos.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategorias.Text),
                ValorPizza = decimal.Parse(TextBoxValor.Text),
                ValorBorda = decimal.Parse(TextBoxValorBorda.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_9_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanhos.Items.Clear();
            listBoxTamanhos.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategorias.Items.Clear();
            listBoxCategorias.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }
    }
}
