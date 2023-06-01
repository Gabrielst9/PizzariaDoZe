using PizzariaDoZe.Telas.DataGridView_s;
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
    public partial class Tela_Cadastros : Form
    {
        public Tela_Cadastros()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
        }

        private void BTN_Cadastrar_Ingredientes_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroIngredientes cad1 = new();
            cad1.Show();
        }

        private void BTN_Cadastro_Sabores_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroSabores cad2 = new();
            cad2.Show();
        }

        private void BTN_Sair_TelaCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaAdm form1 = new TelaAdm();
            form1.Show();
        }

        private void Titulo_Principal_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CadastrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroCliente cad = new CadastroCliente();
            cad.Show();
        }

        private void BTN_CadastroValores_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastroValores cad = new CadastroValores();
            cad.Show();
        }

        private void BTN_CadastrarFuncionarios_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaFuncionario cad = new TelaFuncionario();
            cad.Show();
        }

        private void BTN_CadastrarProdutos_Click(object sender, EventArgs e)
        {
            this.Close();
            CadastrarProdutos cad = new CadastrarProdutos();
            cad.Show();
        }

        //Chamando o DataGridView na tela
        private void BtnListarEnderecos_Click(object sender, EventArgs e)
        {
            ListarEnderecos t8 = new();
            t8.Show();
        }


        //Chamando o DataGridView na tela
        private void BtnListarClientes_Click(object sender, EventArgs e)
        {
            ListarClientes lc = new ListarClientes();
            lc.Show();
        }
    }
}
