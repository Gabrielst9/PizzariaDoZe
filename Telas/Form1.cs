using PizzariaDoZe.Telas;

namespace PizzariaDoZe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btn20_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CADASTRAR_Click(object sender, EventArgs e)
        {
            TELA_CADASTROS t7 = new();
            t7.Show();
        }

        private void BTN_PEDIDOS_Click(object sender, EventArgs e)
        {

        }
    }
}