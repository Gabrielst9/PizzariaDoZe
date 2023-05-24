using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.Globalization;


namespace PizzariaDoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Chamando o banco de dados SQL Server
            DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            //Chamando o MySql
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ? 
                ConfigurationManager.AppSettings.Get("IdiomaRegiao") : ""; 
            //ajusta o idioma/região
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao!);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // valida se a base de dados já existe e se esta configurada corretamente
            ValidaConexaoDB();
            Application.Run(new TelaInicial());

        }
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new Tela_Configuracoes().ShowDialog();
                ValidaConexaoDB();
            }
        }

    }
}