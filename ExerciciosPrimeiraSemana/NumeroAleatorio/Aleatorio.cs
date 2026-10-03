namespace ExerciciosPrimeiraSemana.NumeroAleatorio
{
    internal class Aleatorio
    {
        // Instância da classe Random para gerar números aleatórios
        Random random = new Random();

        // Método para executar o jogo de adivinhação
        public void Executar()
        {
            while (true)
            {
                GerarNumeroAleatorio();
                Console.WriteLine("Deseja tentar novamente? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() != "s")
                {
                    break;
                }
            }
        }

        // Método para gerar um número aleatório e comparar com o valor digitado pelo usuário
        private void GerarNumeroAleatorio()
        {
            int numeroAleatorio = random.Next(1, 3); // Gera um número aleatório entre 1 e 50
            Console.WriteLine("Digite um número entre 1 e 50:");
            var valorDigitado = int.Parse(Console.ReadLine()); 
                            // aqui tive a ideia de chamar o Calculo.ExecutarCalculadora();
                            // para entregar o valor vindo da calculadora e comparar com o numero aleatorio

            if (numeroAleatorio == valorDigitado)
            {
                Console.WriteLine("Parabéns! Você acertou o número aleatório!");
            }
            else
            {
                Console.WriteLine($"Número aleatório gerado: {numeroAleatorio}");
                Console.WriteLine("Tente novamente!");
            }
        }
    }
}
