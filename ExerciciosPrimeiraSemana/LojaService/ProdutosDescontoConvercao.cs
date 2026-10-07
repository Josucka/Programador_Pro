using ExerciciosPrimeiraSemana.ConversorValores;
using ExerciciosPrimeiraSemana.Exercicio1;
using ExerciciosPrimeiraSemana.NumeroAleatorio;


namespace ExerciciosPrimeiraSemana.LojaService
{
    internal class ProdutosDescontoConvercao
    {
        Aleatorio aleatorio = new Aleatorio();

        public static void Executar()
        {
            //chamado do método que retorna a lista de produtos
            List<Produtos> produto = ProdutoServices.ExecutarList();
            //instanciando a classe conversor para utilizar o método de conversão de moedas
            // Conversor conversor = new Conversor(); // removido porque os métodos são estáticos

            //criando interação com o usuário para escolher um produto da lista
            Console.WriteLine("Escolha o produto:");
            var escolha = Console.ReadLine().ToUpper();

            //verificando se o produto escolhido existe na lista de produtos
            bool encontrado = false;

            foreach (var p in produto)
            {
                if (escolha == p.Nome.ToUpper())
                {
                    encontrado = true;

                    Console.WriteLine("Produto encontrado");

                    // Perguntar moeda
                    Console.WriteLine("Escolha a moeda:");
                    Console.WriteLine("1 - Dólar");
                    Console.WriteLine("2 - Euro");
                    Console.WriteLine("3 - Libra");
                    int moedaEscolhida = Convert.ToInt32(Console.ReadLine());
                    double valorConvertido = 0;

                    switch (moedaEscolhida)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu Dolar.");
                            valorConvertido = Conversor.ConverteDolar((double)p.Preco);
                            Console.WriteLine($"Produto: {p.Nome} - € Valor convertido: {valorConvertido:F2}");
                            break;

                        case 2:
                            Console.WriteLine("Você escolheu Euro.");
                            valorConvertido = Conversor.ConverteEuro((double)p.Preco);
                            Console.WriteLine($"Produto: {p.Nome} - € Valor convertido: {valorConvertido:F2}");
                            break;

                        case 3:
                            Console.WriteLine("Você escolheu Libra.");
                            valorConvertido = Conversor.ConverteLibra((double)p.Preco);
                            Console.WriteLine($"Produto: {p.Nome} - € Valor convertido: {valorConvertido:F2}");
                            break;
                        default:
                            Console.WriteLine("Moeda inválida. Tente novamente.");
                            break;
                    }

                    break;
                }
            }

            //se o produto não for encontrado, exibir mensagem de produto inválido
            if (!encontrado)
            {
                Console.WriteLine("Produto inválido.");
            }
        }   
    }
}
