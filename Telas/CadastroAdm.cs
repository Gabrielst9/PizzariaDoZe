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
