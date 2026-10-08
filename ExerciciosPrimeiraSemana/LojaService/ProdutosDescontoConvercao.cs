using ExerciciosPrimeiraSemana.ConversorValores;
using ExerciciosPrimeiraSemana.Exercicio1;

namespace ExerciciosPrimeiraSemana.LojaService
{
    //O exercicio é interagir com o cliente para escolher um produto da lista de produtos, verificar se o produto existe na lista,
    //perguntar ao cliente qual moeda deseja utilizar para conversão e exibir o valor convertido do produto escolhido.
    internal class ProdutosDescontoConvercao
    {

        //O método Executar é responsável por interagir com o usuário, permitindo que ele escolha um produto da lista,
        // tente acertar um número aleatório para ganhar desconto e, em seguida, escolha a moeda para conversão do valor do produto com desconto.
        public static void Executar()
        {
            //tive que insranciar a classe Random para poder utilizar o método Next, que gera um número aleatório, classe nativa do C#.
            Random random = new Random();
            //chamado do método que retorna a lista de produtos
            List<Produtos> produto = ProdutoServices.ExecutarList();
            //instanciando a classe conversor para utilizar o método de conversão de moedas
            // Conversor conversor = new Conversor(); // removido porque os métodos são estáticos

            //criando interação com o usuário para escolher um produto da lista
            Console.WriteLine("Escolha o produto:");
            var escolha = Console.ReadLine().ToUpper();

            //verificando se o produto escolhido existe na lista de produtos
            bool encontrado = false;

            foreach (var p in produto) //é um loop que percorre a lista produto, produto aqui é uma variavel local chamada do metodo ExecutarList. 
            {
                if (escolha == p.Nome.ToUpper())
                {
                    encontrado = true;

                    Console.WriteLine("Produto encontrado");
                    Console.WriteLine("Tente acertar o numero para ganhar desconto");
                    //para usar o random, é necessário instanciar a classe Random e chamar o método Next,
                    //que recebe dois parametros, pois queremos que o numero secreto seja entre 1 e 5.
                    int numeroSecreto = random.Next(1, 5); 
                    int tentativas = 0;
                    bool acertou = false;

                    //essa condicional serve para limitar o numero de tentativas do usuario
                    while (!acertou && tentativas < 3)
                    {
                        Console.WriteLine("Digite um número entre 1 e 5:");
                        int palpite = Convert.ToInt32(Console.ReadLine());
                        tentativas++;

                        if (palpite == numeroSecreto)
                        {
                            acertou = true;
                            Console.WriteLine("Parabéns! Você acertou o número e ganhou desconto.");
                            decimal precoComDesconto = p.AplicarDesconto(30);//Aplicando o desconto de 30% no preço do produto
                            MoedaConvertida(p, precoComDesconto); //O metodo pede dois parametros
                        }

                        if (!acertou)
                        {
                            Console.WriteLine(
                            $"Que pena! O número era {numeroSecreto}."
                            );
                        }
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

        //Metodo criado para identificar a moeda escolhida pelo cliente e exibir
        //o valor convertido aplicando o desconto que o cliente ganhou por ter acertado o random
        private static void MoedaConvertida(Produtos p, decimal precoComDesconto)
        {
            // Perguntar moeda
            Console.WriteLine("Escolha a moeda:");
            Console.WriteLine("1 - Dólar");
            Console.WriteLine("2 - Euro");
            Console.WriteLine("3 - Libra");
            int moedaEscolhida = Convert.ToInt32(Console.ReadLine());
            double valorConvertido = 0;
            
            switch (moedaEscolhida)
            {
                //dentro do switch, o case é utilizado para verificar qual moeda foi escolhida pelo cliente
                //e chamar o método de conversão correspondente.
                //O valor convertido é exibido com duas casas decimais utilizando o formato F2.
                case 1:
                    Console.WriteLine("Você escolheu Dolar.");
                    //metodo de conversão de dolar recebe um parametro do tipo double, por isso o cast (double) é necessário.
                    valorConvertido = Conversor.ConverteDolar((double)precoComDesconto);
                    Console.WriteLine($"Produto: {p.Nome} - US$ Valor convertido: {valorConvertido:F2}");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu Euro.");
                    valorConvertido = Conversor.ConverteEuro((double)precoComDesconto);
                    Console.WriteLine($"Produto: {p.Nome} - € Valor convertido: {valorConvertido:F2}");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu Libra.");
                    valorConvertido = Conversor.ConverteLibra((double)precoComDesconto);
                    Console.WriteLine($"Produto: {p.Nome} - £ Valor convertido: {valorConvertido:F2}");
                    break;
                default:
                    Console.WriteLine("Moeda inválida. Tente novamente.");
                    break;
            }
        }
    }
}
