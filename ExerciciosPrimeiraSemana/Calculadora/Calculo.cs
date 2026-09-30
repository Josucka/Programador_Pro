namespace ExerciciosPrimeiraSemana.Calculadora;

//Uma classe simples
public class Calculo
{
    //Variaveis para armazenar os números e a operação
    double numero1;
    double numero2;
    string operacao;
    double resultado = 0;

    //Metodo que executa a calculadora
    public void ExecutarCalculadora()
    {
        Console.Write("Digite o primeiro número: ");
        if (!double.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }
        
        Console.Write("Digite a operação (+, -, *, /): ");
        operacao = Console.ReadLine() ?? "";

        Console.Write("Digite o segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        switch (operacao)
        {
            case "+":
                resultado = Soma(numero1, numero2);
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
                    return;
                }
                resultado = Divisao(numero1, numero2);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return;
        }

        Console.WriteLine($"Resultado: {resultado}");
    }

    //Metodos privados para realizar as operações
    private double Soma(double a, double b)
    {
        return a + b;
    }

    private double Subtracao(double a, double b)
    {
        return a - b;
    }

    private double Multiplicacao(double a, double b)
    {
        return a * b;
    }

    private double Divisao(double a, double b)
    {
        return a / b;
    }
}

