using static ExerciciosPrimeiraSemana.Placa;

class Program
{
    static void Main()
    {
        List<Placas> placas = new List<Placas>()
        {
            new Placas {Distacia = 0, Texto = "Bem vindo"},
            new Placas {Distacia = 1, Texto = "1Km"},
            new Placas {Distacia = 2, Texto = "Obras"},
            new Placas {Distacia = 4, Texto = "3Km"},
            new Placas {Distacia = 3, Texto = "2Km"},
            new Placas {Distacia = 5, Texto = "Escola"},
            new Placas {Distacia = 6, Texto = "4Km"},
            new Placas {Distacia = 8, Texto = "6Km"},
            new Placas {Distacia = 7, Texto = "5Km"},
            new Placas {Distacia = 9, Texto = "7Km"},
            new Placas {Distacia = 11, Texto = "9Km"},
            new Placas {Distacia = 10, Texto = "8Km"},
            new Placas {Distacia = 12, Texto = "10Km"},
            new Placas {Distacia = 13, Texto = "11Km"},
            new Placas {Distacia = 14, Texto = "12Km"},
            new Placas {Distacia = 15, Texto = "Ate que enfim"}
        };

        var ordenadas = placas.OrderBy(p => p.Distacia);

        foreach (var placa in ordenadas)
        {
            Console.WriteLine(placa.Texto);
        }
    }
}

