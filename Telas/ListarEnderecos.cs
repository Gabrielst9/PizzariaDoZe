using PizzariaDoZe_DAO.Endereco;
using PizzariaDoZe_DAO.Ingredientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe.Telas
{
    public partial class ListarEnderecos : Form
    {

        private EnderecoDAO enderecoDAO;
        public ListarEnderecos()
        {
            InitializeComponent();
            enderecoDAO = new EnderecoDAO();
            AtualizarTela();
        }
        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var endereco = new Endereco();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
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

    }
}
