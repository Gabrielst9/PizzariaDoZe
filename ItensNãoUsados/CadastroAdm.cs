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
    public partial class CadastroAdm : Form
    {
        public CadastroAdm()
        {
            InitializeComponent();

            this.ConfigurarShortCut();

            Textbox4_NOME.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox4_NOME.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox4_EMAIL.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox4_EMAIL.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox4_ENDERECO.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox4_ENDERECO.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox4_SENHA.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox4_SENHA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox4_CNF_SENHA.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox4_CNF_SENHA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Maskedbox4_CPF.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox4_CPF.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Maskedbox4_TELEFONE.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox4_TELEFONE.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void Maskedbox4_TELEFONE_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Text4_SENHA_Click(object sender, EventArgs e)
        {
        }

        private void Btn4_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crud1_Load(object sender, EventArgs e)
        {

        }

        private void Text4_CNF_SENHA_Click(object sender, EventArgs e)
        {

        }
    }
}
