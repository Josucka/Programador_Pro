namespace ExerciciosPrimeiraSemana.Exercicio1
{
    // A classe Produtos representa um produto com propriedades
    public class Produtos 
    {
        // Propriedades da classe Produtos
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        //Aqui um metodo que aplica um desconto ao preço do produto
        public decimal AplicarDesconto(decimal percentualDesconto)
        {
            return Preco - (Preco * percentualDesconto / 100);
        }
    }

    // A classe ProdutoServices é uma classe estática que contém métodos relacionados à exibição de detalhes de produtos.
    // ela possui o método ExibirDetalhes, que recebe uma funçao ExecutarList() para exibir os detalhes dos produtos no console.
    public static class ProdutoServices
    {
        // O método ExibirDetalhes recebe um objeto do tipo Produtos como parâmetro
        // e chama o método ExecutarList para exibir os detalhes dos produtos no console.
        public static void ExibirDetalhes(Produtos produto)
        {
            ExecutarList();
        }

        // O método ExecutarList é um tipo list,
        // percorre essa lista usando um foreach e exibe as propriedades
        // Nome, Quantidade e Preco de cada produto formatadas no console.
        public static List<Produtos> ExecutarList()
        {
            //var desconto = new Aleatorio();
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
                    produto.Preco = produto.AplicarDesconto(20); 
                }

                Console.WriteLine($"Nome: {produto.Nome}, " +
                                  $"Quantidade: {produto.Quantidade}, " +
                                  $"Preço: {produto.Preco}");
                
            }
            //inside: é necessario o foreach para percorrer a lista de produtos e exibir os detalhes de cada produto no console.
            //O foreach itera sobre cada objeto da lista produtos,
            //permitindo acessar suas propriedades Nome, Quantidade e Preco para exibição formatada.
            return produtos;
        }       
    }
}
