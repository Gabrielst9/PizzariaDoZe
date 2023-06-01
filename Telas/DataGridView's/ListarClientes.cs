using PizzariaDoZe.DAO;
using PizzariaDoZe_DAO.Cliente;
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

namespace PizzariaDoZe.Telas.DataGridView_s
{
    public partial class ListarClientes : Form
    {
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private ClienteDAO clienteDAO;
        public ListarClientes()
        {
            InitializeComponent();
            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewClientes.Columns.Clear();
                dataGridViewClientes.AutoGenerateColumns = true;
                dataGridViewClientes.DataSource = linhas;
                dataGridViewClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
