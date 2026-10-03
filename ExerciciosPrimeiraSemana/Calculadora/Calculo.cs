namespace ExerciciosPrimeiraSemana.Calculadora;

//Uma classe simples
public class Calculo
{
    //Metodo que executa a calculadora
    public static double ExecutarCalculadora()
    {
        //Variaveis para armazenar os números e a operação
        double numero1;
        double numero2;
        string operacao;
        double resultado;

        Console.Write("Digite o primeiro número: ");
        if (!double.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Entrada inválida.");
        }
        
        Console.Write("Digite a operação (+, -, *, /): ");
        operacao = Console.ReadLine() ?? "";

        Console.Write("Digite o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Entrada inválida.");
        }

        switch (operacao)
        {
            case "+":
                resultado = Soma(numero1,  numero2);
                break;
            case "-":
                resultado = Subtracao(numero1, numero2);
                break;
            case "*":
                resultado = Multiplicacao(numero1, numero2);
                break;
            case "/":
                if (numero2 == 0)
                {
                    Console.WriteLine("Divisão por zero.");
                }
                resultado = Divisao(numero1, numero2);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return 0;
        }
        
        return resultado;
    }

    //Metodos privados para realizar as operações
    #region
    private static double Soma(double a, double b)
    {
        return a + b;
    }

    private static double Subtracao(double a, double b)
    {
        return a - b;
    }

    private static double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    private static double Divisao(double a, double b)
    {
        return a / b;
    }

    #endregion
}

