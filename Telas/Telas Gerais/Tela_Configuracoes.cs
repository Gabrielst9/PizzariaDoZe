using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class Tela_Configuracoes : Form
    {
        public Tela_Configuracoes()
        {
            InitializeComponent();
            this.ConfigurarShortCut();
            
            //seleciona no comboBox o idioma/cultura atual
            //seleciona no combo a cultura atual
            Combo20Idiomas.SelectedItem = ConfigurationManager.AppSettings.Get("Cultura");
            //Combo20Idiomas.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            
            // busca os dados com nome BD
            ConnectionStringSettings connectionStringSettings =
            ConfigurationManager.ConnectionStrings["BD"];
            // obtém o providerName e atualiza em tela
            comboBoxProvider.Text = connectionStringSettings.ProviderName;
            // obtém a connectionString e atualiza em tela
            textBoxStringDeConexao.Text = connectionStringSettings.ConnectionString;

            //adiciona eventos em geral, exemplo: ganhar e perder o foco
            Funcoes.EventoFocoCampos(this);
        }
        /// <summary>
        /// Este botão salva as configurações definidas pelo usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn20Salvar_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em ProjetoPastelariaDoZe_2023.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", Combo20Idiomas.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");
            if (Checkbox20Reiniciar.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }




            //abre o arquivo local como leitura/escrita - ControleEstoqueDoZe.exe.config
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //altera os valores de provider e da connectionStrings com nome BD
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxStringDeConexao.Text;
            //salva as alterações
            config.Save(ConfigurationSaveMode.Modified, true);
            //recarrega os dados da seção especificada
            ConfigurationManager.RefreshSection("connectionStrings");
            //fecha a tela
            Close();
            //dispara msg para usuário
            _ = MessageBox.Show("Dados alterados com sucesso!");


        }
    }
}
