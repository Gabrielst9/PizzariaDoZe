﻿using PizzariaDoZe_DAO.Endereco;
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
using PizzariaDoZe;
using PizzariaDoZe_DAO.Funcionario;

namespace PizzariaDoZe.Telas
{
    public partial class CadastroFuncionario : Form
    {
        private readonly EnderecoDAO enderecoDAO;
        private string provider;
        private string strConnection;


        private readonly FuncionarioDAO funcionarioDAO;
        public CadastroFuncionario()
        {
            InitializeComponent();

            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO();


            //Mesma coisa que isso: enderecoDAO = new EnderecoDAO(provider, strConnection);
            enderecoDAO = new EnderecoDAO();
            enderecoDAO.Provider = provider;
            enderecoDAO.StringConexao = strConnection;

            //Função Leave da maskedbox CEP
            userControlEnderecoFuncionarios.maskedTextBoxCep.Leave += maskedTextBoxCep_Leave;

            //Atualiza as cores das letras
            this.AtualizaCorLetras();
            //coloca imagem nos forms
            this.ColocaImagemForm();
            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
            //configura os atalhos de shortcuts
            this.ConfigurarShortCut();

            // cria a instancia da classe da model
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);


            CrudFuncionario.BtnSalvar.Click += BtnSalvar_Click;

        }

        private void maskedTextBoxCep_Leave(object sender, EventArgs e)
        {
            if (userControlEnderecoFuncionarios.maskedTextBoxCep.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = userControlEnderecoFuncionarios.maskedTextBoxCep.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                userControlEnderecoFuncionarios.TextBoxIdEndereco.Text = "";
                userControlEnderecoFuncionarios.maskedTextBoxCep.Text = "";
                userControlEnderecoFuncionarios.TextBoxLogradouro.Text = "";
                userControlEnderecoFuncionarios.TextBoxBairro.Text = "";
                userControlEnderecoFuncionarios.TextBoxCidade.Text = "";
                userControlEnderecoFuncionarios.comboBoxUF.Text = "";
                userControlEnderecoFuncionarios.TextBoxPais.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    userControlEnderecoFuncionarios.TextBoxIdEndereco.Text = row["id"].ToString(); ;
                    userControlEnderecoFuncionarios.maskedTextBoxCep.Text = row["cep"].ToString(); ;
                    userControlEnderecoFuncionarios.TextBoxLogradouro.Text = row["logradouro"].ToString(); ;
                    userControlEnderecoFuncionarios.TextBoxBairro.Text = row["bairro"].ToString(); ;
                    userControlEnderecoFuncionarios.TextBoxCidade.Text = row["cidade"].ToString(); ;
                    userControlEnderecoFuncionarios.comboBoxUF.Text = row["uf"].ToString(); ;
                    userControlEnderecoFuncionarios.TextBoxPais.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalvar_Click(object? sender, EventArgs e)
        {
            if (userControlEnderecoFuncionarios.TextBoxIdEndereco.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = TextboxNome.Text,
                Cpf = MaskedboxCpf.Text,
                Matricula = TextBoxMatricula.Text,
                Senha = Funcoes.Sha256Hash(TextBoxSenha.Text),
                Grupo = (RadioBtnAdministrador.Checked) ? '1' : (RadioBtnAtendente.Checked) ? '2' : '3',
                Motorista = ComboBoxCarteira.Text,
                Validade = DateTimePickerValidade.Value,
                Observacao = TextBoxObservacao.Text,
                Telefone = MaskedboxTelefone.Text,
                Email = TextboxEmail.Text,
                EnderecoId = int.Parse(userControlEnderecoFuncionarios.TextBoxIdEndereco.Text),
                Numero = userControlEnderecoFuncionarios.TextBoxNumero.Text,
                Complemento = userControlEnderecoFuncionarios.TextBoxComplemento.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrudFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
