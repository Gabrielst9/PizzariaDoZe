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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            Textbox5_NOME.Enter += new
          EventHandler(Funcoes.CampoEventoEnter!);
            Textbox5_NOME.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox5_EMAIL.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox5_EMAIL.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox5_ENDERECO.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox5_ENDERECO.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Textbox5_SENHA.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Textbox5_SENHA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            TextBox5_CNF_SENHA.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            TextBox5_CNF_SENHA.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Maskedbox5_CPF.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox5_CPF.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            Maskedbox5_TELEFONE.Enter += new
           EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox5_TELEFONE.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void Btn5_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
