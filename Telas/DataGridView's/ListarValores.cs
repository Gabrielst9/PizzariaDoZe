﻿using PizzariaDoZe.DAO;
using PizzariaDoZe_DAO.Sabor;
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

namespace PizzariaDoZe.Telas.Telas_De_Cadastro
{
    public partial class ListarValores : Form
    {
        public ValorDAO valorDAO;

        // pega os dados do banco de dados
        string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
        string strConnection =
        ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        public ListarValores()
        {
            InitializeComponent();
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);


            AtualizarTela();
        }

        private void DataGridViewDados_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == this.dataGridViewValor.NewRowIndex || e.Value.ToString().Trim().Length == 0)
            {
                return;
            }
            if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Grupo"))
            {
                e.Value = ClassEnum.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Categoria"))
            {
                e.Value = ClassEnum.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Tamanho"))
            {
                e.Value = ClassEnum.GetDescription((EnumValorTamanho)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Tipo"))
            {
                e.Value = ClassEnum.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("CPF"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("CEP"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:00\.000\-000}", value);
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Telefone"))
            {
                long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
            }
            else if (this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Valor") || this.dataGridViewValor.Columns[e.ColumnIndex].Name.Equals("Valor Borda"))
            {
                // formata valor numérico com duas casa decimais
                double d = double.Parse(e.Value.ToString());

                e.Value = d.ToString("N2");
            }
        }

        private void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = valorDAO.Buscar(valor);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewValor.Columns.Clear();
                dataGridViewValor.AutoGenerateColumns = true;
                dataGridViewValor.DataSource = linhas;
                dataGridViewValor.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
