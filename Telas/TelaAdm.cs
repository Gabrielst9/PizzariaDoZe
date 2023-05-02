using PizzariaDoZe.Telas;

namespace PizzariaDoZe
{
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
        }
        private void Btn20_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CADASTRAR_Click(object sender, EventArgs e)
        {
            Tela_Cadastros t7 = new();
            t7.Show();
        }

        private void BTN_PEDIDOS_Click(object sender, EventArgs e)
        {

        }
    }
}