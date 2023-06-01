using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzariaDoZe.Telas;

namespace PizzariaDoZe
{
    public partial class CadastroSabores : Form
    {
        public CadastroSabores()
        {
            InitializeComponent();

            this.ConfigurarShortCut();

            //Ajuste do Foco campo 
            SABOR_NOME_TEXT.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            SABOR_NOME_TEXT.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste do Foco campo 
            SABOR_COD_TEXT.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            SABOR_COD_TEXT.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste do Foco campo 
            SABOR_CATEGORIA.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            SABOR_CATEGORIA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste do Foco campo 
            SABOR_TIPO.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            SABOR_TIPO.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void SAIR_SABORES_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Tela_Cadastros cad1 = new();
            cad1.Show();

        }

        private void Btn_8_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroSabores_Load(object sender, EventArgs e)
        {

        }
    }
}
