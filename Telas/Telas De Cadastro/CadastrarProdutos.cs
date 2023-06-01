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
    public partial class CadastrarProdutos : Form
    {
        public CadastrarProdutos()
        {
            InitializeComponent();

            this.ConfigurarShortCut();


            TextBoxNomeCadastros.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            TextBoxNomeCadastros.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            TextBoxValorCadastros.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            TextBoxValorCadastros.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void Btn_10_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
