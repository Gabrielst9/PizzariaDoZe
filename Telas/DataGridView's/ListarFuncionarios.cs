using PizzariaDoZe_DAO.Funcionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.ClassEnum;

namespace PizzariaDoZe.Telas.DataGridView_s
{
    public partial class ListarFuncionarios : Form
    {
        private FuncionarioDAO funcionarioDAO;
        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

        public ListarFuncionarios()
        {
            InitializeComponent();
            // cria a instancia da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);
            dataGridViewFuncionarios.CellFormatting += dataGridViewFuncionarios_CellFormatting;
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = funcionarioDAO.Buscar(funcionario);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewFuncionarios.Columns.Clear();
                dataGridViewFuncionarios.AutoGenerateColumns = true;
                dataGridViewFuncionarios.DataSource = linhas;
                dataGridViewFuncionarios.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridViewFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewFuncionarios.NewRowIndex || e.Value == null || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }

            if (this.dataGridViewFuncionarios.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                if (int.TryParse(e.Value.ToString(), out int grupoValue))
                {
                    e.Value = ClassEnum.GetDescription((EnumFuncionarioGrupo)grupoValue);
                }
            }
            else if (this.dataGridViewFuncionarios.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                if (long.TryParse(e.Value.ToString().Replace(" ", ""), out long value))
                {
                    e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
                }
            }
            else if (this.dataGridViewFuncionarios.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                if (long.TryParse(e.Value.ToString().Replace(" ", ""), out long value))
                {
                    e.Value = string.Format(@"{0:00\.000\-000}", value);
                }
            }
            else if (this.dataGridViewFuncionarios.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                if (long.TryParse(e.Value.ToString().Replace(" ", ""), out long value))
                {
                    e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
                }
            }
            else if (this.dataGridViewFuncionarios.Columns[e.ColumnIndex].Name.Equals("Valor"))
            {
                if (double.TryParse(e.Value.ToString().Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double d))
                {
                    e.Value = d.ToString("N2");
                }
                else
                {
                    e.Value = string.Empty; // ou algum valor padrão apropriado caso não seja um número válido
                }
            }
        }
    }
}

