using PizzariaDoZe_DAO;
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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);

            //Ajuste de Foco campo nome
            Textbox_NOME.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox_NOME.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste de Foco campo endereço
            Textbox_ENDERECO.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox_ENDERECO.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste de Foco campo email
            Textbox_EMAIL.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Textbox_EMAIL.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste de Foco campo cpf
            Maskedbox_CPF.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox_CPF.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
            //Ajuste do Foco campo telefone
            Maskedbox_TELEFONE.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            Maskedbox_TELEFONE.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void Btn2_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crud1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
