using PizzariaDoZe.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class CadastroIngredientes : Form
    {
        public CadastroIngredientes()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

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

        private void Btn_Salvar_Ingredientes_Click(object sender, EventArgs e)
        {

        }

        private void Btn_11_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
