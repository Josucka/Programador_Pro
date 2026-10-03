using ExerciciosPrimeiraSemana.Calculadora;

namespace ExerciciosPrimeiraSemana.ConversorValores
{
    internal class Conversor
    {
        // classe para armazenar as taxas de conversão
        class Moedas
        {
            public const double Dolar = 5.25;
            public const double Euro = 5.50;
            public const double Libra = 6.20;
        }

        // método para executar o conversor de valores
        public static void Executar()
        {
            //variavel para controlar se o usuário deseja continuar ou não
            bool continuar = true;

            //uma condicional loop para continuar executando o programa enquanto o usuário desejar
            while (continuar)
            {
                //metodo statico nao precisa ser referenciado por "new" para ser instanciado, apenas pelo nome da classe
                //esta sendo chamado dentro do loop para que o usuário possa realizar várias operações sem precisar reiniciar o programa
                double conta = Calculo.ExecutarCalculadora();
               
                //metodos de entrada e saída de dados para o usuário
                Console.WriteLine($"Value a ser convertido: {conta:F2}");
                Console.WriteLine("Escolha a moeda para conversão: ");
                Console.WriteLine("1 - Dólar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("3 - Libra");
                int opcao = Convert.ToInt32(Console.ReadLine());

                //condicional switch para verificar a opção escolhida
                //pelo usuário e realizar a conversão correspondente
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"O valor em Dólar é: {ConverteDolar(conta):F2}");
                        break;
                    case 2:
                        Console.WriteLine($"O valor em Euro é: {ConverteEuro(conta):F2}");
                        break;
                    case 3:
                        Console.WriteLine($"O valor em Libra é: {ConverteLibra(conta):F2}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                //pergunta ao usuário se deseja realizar outra conversão
                Console.WriteLine("Deseja realizar outra conversão? (0/1)");
                string resposta = Console.ReadLine().ToUpper();
               
                continuar = resposta == "1";
            }
            Console.WriteLine("Programa encerrado.");
        }

        //métodos privados para realizar as conversões
        #region
        private static double ConverteDolar(double calculo)
        {
            return  calculo / Moedas.Dolar;
        }
        private static double ConverteEuro(double calculo)
        {
            return calculo / Moedas.Euro;
        }
        private static double ConverteLibra(double calculo)
        {
            return calculo / Moedas.Libra;
        }
        #endregion
    }
}