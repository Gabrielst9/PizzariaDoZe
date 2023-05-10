﻿using PizzariaDoZe.Telas;
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
using System.Configuration;

namespace PizzariaDoZe
{
    public partial class CadastroIngredientes : Form
    {
        private readonly IngredienteDAO dao; //No construtor da classe FormMarcas vamos instanciar
        public CadastroIngredientes()
        {
            InitializeComponent();

            dao = new IngredienteDAO();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);


            crud1.Btn12_Salvar.Click += Btn12_Salvar_Click;

            //Ajuste do Foco campo Nome
            ING_NOME_TEXT.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            ING_NOME_TEXT.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste do Foco campo ID
            ING_ID_TEXT.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            ING_ID_TEXT.Leave += new
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

        private void Btn12_Salvar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente(ING_NOME_TEXT.Text);


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
    }
}
