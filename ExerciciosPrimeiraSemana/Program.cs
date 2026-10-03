using ExerciciosPrimeiraSemana.Calculadora;
using ExerciciosPrimeiraSemana.Exercicio1;
using ExerciciosPrimeiraSemana.ConversorValores;
using ExerciciosPrimeiraSemana.NumeroAleatorio;



internal partial class Program
{
    static void Main()
    {

        #region
        //o exercicio aqui esta em criar uma instancia da classe Calculo e
        //chamar o metodo Executar passando a instancia criada como parametro"calculo"
        //var calculo = new Calculo(); //essa instancia ja esta sendo criada dentro do metodo Executar na classe Conversor, entao nao precisa criar aqui
        //Console.WriteLine(calculo);
        #endregion

        var numero = new Aleatorio(); 
        numero.Executar();

        //o exercicio aqui esta em criar uma instancia da classe Conversor
        //a instancia da classe Conversor é criada e o metodo Executar
        //é chamado para realizar a conversão de valores.
        //Conversor.Executar();


        //o exercicio aqui mostra que a classe OrderByList possui um metodo estatico chamado Executar,
        //que pode ser chamado diretamente sem a necessidade de criar uma instancia da classe.
        //OrderByList.Executar();


        //o exercicio aqui esta em criar uma instancia da classe Produtos e
        //chamar o metodo ExibirDetalhes passando a instancia criada como parametro"produto"
        var produto = new Produtos(); // Aqui estamos intaciando o Objeto da classe Produtos
        ProdutoServices.ExibirDetalhes(produto);


        
        
    }
}

