using PizzariaDoZe_DAO.Ingredientes;
using PizzariaDoZe_DAO.Sabor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PizzariaDoZe.ClassEnum;
using PizzariaDoZe_DAO;
using System.Configuration;

namespace PizzariaDoZe.Telas.DataGridView_s
{
    public partial class ListarSabores : Form
    {
        public SaborDAO saborDAO;
        public ListarSabores()
        {
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            InitializeComponent();


            saborDAO = new SaborDAO(provider, strConnection);

            AtualizarTela();
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

        private void AtualizarTela()
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
    }
}
