using ExerciciosPrimeiraSemana.BoletimEstudante.Date.ExerciciosPrimeiraSemana.BoletimEstudante;

namespace ExerciciosPrimeiraSemana.BoletimEstudante
{
    internal class ServiceNota
    {
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;
        private Aluno aluno;

        //essa classe é responsável por executar a lógica de entrada de dados e salvar no repositório 
        public void Executar()
        {
            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Nota 1:");
            nota1 = Convert.ToDouble(Console.ReadLine());
        
            Console.WriteLine("Nota 2:");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nota 3:");
            nota3 = Convert.ToDouble(Console.ReadLine());

            aluno = new Aluno
            {
                Nome = nome,
                Nota1 = nota1,
                Nota2 = nota2,
                Nota3 = nota3
            };

            AlunoRepository.SalvarAluno(aluno);// Salva o aluno no repositório
            AlunoRepository.ListarAlunos();// Lista todos os alunos salvos no repositório
        }
    }
}
