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
    public partial class CadastroValores : Form
    {
        public CadastroValores()
        {
            InitializeComponent();

            TextBox2Valor.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            TextBox2Valor.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);

            TextBox2ValorBorda.Enter += new
            EventHandler(Funcoes.CampoEventoEnter!);
            TextBox2ValorBorda.Leave += new
            EventHandler(Funcoes.CampoEventoLeave!);
        }

        private void Btn_9_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
