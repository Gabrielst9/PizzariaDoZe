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
    public partial class CadastroEntregador : Form
    {
        public CadastroEntregador()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            Textbox6_NOME.Enter += new
          EventHandler(Funcoes.CampoEventoEnter!);
            Textbox6_NOME.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox6_EMAIL.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox6_EMAIL.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox6_ENDERECO.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox6_ENDERECO.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox6_SENHA.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox6_SENHA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            TextBox6_CNF_SENHA.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            TextBox6_CNF_SENHA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Maskedbox6_CPF.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox6_CPF.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Maskedbox6_TELEFONE.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox6_TELEFONE.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Btn6_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TEXT6_NOME_Click(object sender, EventArgs e)
        {

        }

        private void Maskedbox6_TELEFONE_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void TextBox6_CNF_SENHA_TextChanged(object sender, EventArgs e)
        {
        }

        private void TEXT6_CPF_Click(object sender, EventArgs e)
        {
        }

        private void Textbox5_NOME_TextChanged(object sender, EventArgs e)
        {
        }

        private void Text6_SENHA_Click(object sender, EventArgs e)
        {
        }

        private void TEXT6_TELEFONE_Click(object sender, EventArgs e)
        {
        }

        private void Textbox5_EMAIL_TextChanged(object sender, EventArgs e)
        {
        }

        private void Maskedbox6_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Textbox6_ENDERECO_TextChanged(object sender, EventArgs e)
        {
        }

        private void Text6_CNF_SENHA_Click(object sender, EventArgs e)
        {
        }

        private void TEXT6_EMAIL_Click(object sender, EventArgs e)
        {
        }

        private void TEXT6_ENDERECO_Click(object sender, EventArgs e)
        {
        }

        private void Textbox6_SENHA_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
