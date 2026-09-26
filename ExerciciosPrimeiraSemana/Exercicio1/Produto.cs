
namespace ExerciciosPrimeiraSemana.Exercicio1
{
    public class Produtos
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        //criar uma instância da classe Produtos para aplicar o desconto ao produto específico
        public decimal AplicarDesconto(decimal percentualDesconto)
        {
            return Preco - (Preco * percentualDesconto / 100);
        }
    }

    // A classe Produto é uma classe estática que contém métodos relacionados à exibição de detalhes de produtos.
    // Ela possui o método ExibirDetalhes, que recebe um objeto do tipo Produtos como parâmetro e chama o método ExecutarList para exibir os detalhes dos produtos no console.
    // O método ExecutarList cria uma lista de produtos, percorre essa lista usando um foreach e exibe as propriedades Nome, Quantidade e Preco de cada produto formatadas no console.
    public static class ProdutoServices
    {
        public static void ExibirDetalhes(Produtos produto)
        {
            ExecutarList();
        }

        public static List<Produtos> ExecutarList()
        {
            List<Produtos> produtos = new List<Produtos>()
            {
                new Produtos { Nome = "Notebook", Quantidade = 10, Preco = 2500.00m },
                new Produtos { Nome = "Mouse", Quantidade = 50, Preco = 50.00m },
                new Produtos { Nome = "Teclado", Quantidade = 30, Preco = 150.00m }
            };

            foreach (var produto in produtos)
            {
                // Aplicando um desconto variavel% ao produto,
                // a condicional e posta dentro do foreach para que o desconto seja aplicado
                // apenas ao produto.Nome específico durante a iteração da lista de produtos.
                if (produto.Nome == "Mouse")
                {
                    produto.Preco = produto.AplicarDesconto(30); 
                }

                Console.WriteLine($"Nome: {produto.Nome}, " +
                                  $"Quantidade: {produto.Quantidade}, " +
                                  $"Preço: {produto.Preco}");
            }
            //inside: é necessario o foreach para percorrer a lista de produtos e exibir os detalhes de cada produto no console. O foreach itera sobre cada objeto da lista produtos,
            //permitindo acessar suas propriedades Nome, Quantidade e Preco para exibição formatada.
            return produtos;
        }

       
    }
}
