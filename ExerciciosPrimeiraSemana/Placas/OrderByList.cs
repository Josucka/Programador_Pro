
//A classe define o que um Objeto tem.
public class Placas
{
    //Aqui as propriedades do Objeto 
    public int Distancia { get; set; }
    public string Texto { get; set; }
}


//Classe que contem o metodo Executar()
class OrderByList
{
    //O metodo Executar é estatico, ou seja,
    //pode ser chamado diretamente sem a necessidade de criar uma instancia da classe.
    public static void Executar()
    {
        //variavel do tipo list, que armazena varios valores do mesmo tipo.
        List<Placas> placas = new List<Placas>()
        {
            new Placas {Distancia = 0, Texto = "Bem vindo"},
            new Placas {Distancia = 2, Texto = "Obras"},
            new Placas {Distancia = 1, Texto = "1Km"},
            new Placas {Distancia = 13, Texto = "11Km"},
            new Placas {Distancia = 4, Texto = "3Km"},
            new Placas {Distancia = 3, Texto = "2Km"},
            new Placas {Distancia = 6, Texto = "4Km"},
            new Placas {Distancia = 5, Texto = "Escola"},
            new Placas {Distancia = 8, Texto = "6Km"},
            new Placas {Distancia = 7, Texto = "5Km"},
            new Placas {Distancia = 9, Texto = "7Km"},
            new Placas {Distancia = 11, Texto = "9Km"},
            new Placas {Distancia = 10, Texto = "8Km"},
            new Placas {Distancia = 12, Texto = "10Km"},
            new Placas {Distancia = 15, Texto = "Ate que enfim"},
            new Placas {Distancia = 14, Texto = "12Km"},
        };

        //Guarda valores na memoria, e ordena com o metodo OrderBy,
        //que ordena os valores de acordo com a propriedade Distancia.
        var ordenadas = placas.OrderBy(p => p.Distancia);
        //Exibe os valores ordenados na tela.
        foreach (var placa in ordenadas)
        {
            Console.WriteLine(placa.Texto);
        }
    }
}