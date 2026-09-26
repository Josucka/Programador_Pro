
namespace ExerciciosPrimeiraSemana.Calculadora;
public class Calculo
{
    double numero1;
    double numero2;
    string operacao;
    double resultado = 0;

    public void Executar()
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

