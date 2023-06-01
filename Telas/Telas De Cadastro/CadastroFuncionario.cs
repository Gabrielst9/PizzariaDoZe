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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
            this.AtualizaCorLetras();
            this.ColocaImagemForm();

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);

            this.ConfigurarShortCut();

            //TextboxNome.Enter += new
            //EventHandler(Funcoes.CampoEventoEnter!);
            //TextboxNome.Leave += new
            //EventHandler(Funcoes.CampoEventoLeave!);

            //TextboxEmail.Enter += new
            //EventHandler(Funcoes.CampoEventoEnter!);
            //TextboxEmail.Leave += new
            //EventHandler(Funcoes.CampoEventoLeave!);

            //TextBoxSenha.Enter += new
            //EventHandler(Funcoes.CampoEventoEnter!);
            //TextBoxSenha.Leave += new
            //EventHandler(Funcoes.CampoEventoLeave!);

            //MaskedboxCpf.Enter += new
            //EventHandler(Funcoes.CampoEventoEnter!);
            //MaskedboxCpf.Leave += new
            //EventHandler(Funcoes.CampoEventoLeave!);

            //MaskedboxTelefone.Enter += new
            //EventHandler(Funcoes.CampoEventoEnter!);
            //MaskedboxTelefone.Leave += new
            //EventHandler(Funcoes.CampoEventoLeave!);
        }
    }
}
