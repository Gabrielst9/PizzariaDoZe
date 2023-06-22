using PizzariaDoZe.Compartilhado;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe_DAO;
using PizzariaDoZe.DAO;
using System.Configuration;
using PizzariaDoZe_DAO.Sabor;
using PizzariaDoZe_DAO.Cliente;
using PizzariaDoZe_DAO.Endereco;
using static PizzariaDoZe.ClassEnum;

namespace PizzariaDoZe.Telas.Telas_De_Cadastro
{
    public partial class CadastroPedidos : Form
    {
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        private ClienteDAO clienteDAO;
        private ProdutoDAO produtoDAO;
        private SaborDAO saborDAO;
        public CadastroPedidos()
        {
            InitializeComponent();
            this.ColocaImagemForm();
            Funcoes.EventoFocoCampos(this);

            // cria a instancia da classe da model
            clienteDAO = new ClienteDAO(provider, strConnection);
            produtoDAO = new ProdutoDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if (textBoxNome.Text.Trim().Length <= 0)
            {
                return;
            }
            var cliente = new Cliente
            {
                Nome = textBoxNome.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = clienteDAO.Buscar(cliente);

                //Ataliza o Data Grid
                AtualizarTela();

                // seta os dados na tela
                textBoxNome.Text = "";
                MaskedTextboxCpf.Text = "";
                MaskedTextboxTelefone.Text = "";
                //userControlEnderecoClientes.TextBoxBairro.Text = "";
                //userControlEnderecoClientes.TextBoxCidade.Text = "";
                //userControlEnderecoClientes.comboBoxUF.Text = "";
                //userControlEnderecoClientes.TextBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxNome.Text = row["nome"].ToString(); ;
                    MaskedTextboxCpf.Text = row["cpf"].ToString(); ;
                    MaskedTextboxTelefone.Text = row["telefone"].ToString(); ;
                    //userControlEnderecoClientes.TextBoxBairro.Text = row["bairro"].ToString(); ;
                    //userControlEnderecoClientes.TextBoxCidade.Text = row["cidade"].ToString(); ;
                    //userControlEnderecoClientes.comboBoxUF.Text = row["uf"].ToString(); ;
                    //userControlEnderecoClientes.TextBoxPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewSabores_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewSabores.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = ClassEnum.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = ClassEnum.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = ClassEnum.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewSabores.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());
                e.Value = d.ToString("N2");
            }
        }
        private void AtualizarTelaSabores()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewSabores.Columns.Clear();
                dataGridViewSabores.AutoGenerateColumns = true;
                dataGridViewSabores.DataSource = linhas;
                dataGridViewSabores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTamanho_MouseCaptureChanged(object sender, EventArgs e)
        {
            AtualizarTelaSabores();
        }
    }
}
