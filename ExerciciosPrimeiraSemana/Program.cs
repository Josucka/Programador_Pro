using ExerciciosPrimeiraSemana.Calculadora;
using ExerciciosPrimeiraSemana.Exercicio1;



internal partial class Program
{
    static void Main()
    {
        //o exercicio aqui esta em criar uma instancia da classe Calculo e
        //chamar o metodo Executar passando a instancia criada como parametro"calculo"
        var calculo = new Calculo();
        calculo.Executar();

        //o exercicio aqui mostra que a classe OrderByList possui um metodo estatico chamado Executar,
        //que pode ser chamado diretamente sem a necessidade de criar uma instancia da classe.
        OrderByList.Executar();

        //o exercicio aqui esta em criar uma instancia da classe Produtos e
        //chamar o metodo ExibirDetalhes passando a instancia criada como parametro"produto"
        var produto = new Produtos();
        ProdutoServices.ExibirDetalhes(produto);


    }
}

