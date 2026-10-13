using Microsoft.Extensions.Configuration;

namespace ExerciciosPrimeiraSemana.Config
{
    //metodo para pegar a string de conexao do arquivo appsettings.json
    public static class Configuracao
    {
        //propriedade para armazenar a configuração carregada do arquivo appsettings.json
        //Interface importada do pacote Microsoft.Extensions.Configuration
        private static IConfigurationRoot configuration;

        //construtor estatico para inicializar a configuração
        static Configuracao()
        {
            //cria uma instância de ConfigurationBuilder para construir a configuração
            //SetBasePath define o caminho base para procurar o arquivo de configuração
            //AddJsonFile adiciona o arquivo appsettings.json à configuração
            //Build() constrói a configuração final
            configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile(
                    "appsettings.json",
                    optional: false,
                    reloadOnChange: true)
                .Build();


        }

        //propriedade para acessar a string de conexão do banco de dados que está definida no arquivo appsettings.json
        public static string ConnectionString =>
            configuration.GetConnectionString("SqlServer");
    }
}