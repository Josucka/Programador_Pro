using Microsoft.Data.SqlClient;
using System.Data;

namespace ExerciciosPrimeiraSemana.BoletimEstudante.Date
{

    namespace ExerciciosPrimeiraSemana.BoletimEstudante
    {
        public class AlunoRepository
        {
            public static void SalvarAluno(Aluno aluno)
            {
                try
                {
                    using var conexao = new SqlConnection(ConectionDB.StringConexao);
                    conexao.Open();
                    const string query = @"
                        INSERT INTO Alunos (Nome, Nota1, Nota2, Nota3)
                        VALUES (@Nome, @Nota1, @Nota2, @Nota3);";
                    using var comando = new SqlCommand(query, conexao);
                    comando.Parameters.Add("@Nome", SqlDbType.NVarChar, 100).Value = aluno.Nome;
                    comando.Parameters.Add("@Nota1", SqlDbType.Float).Value = aluno.Nota1;
                    comando.Parameters.Add("@Nota2", SqlDbType.Float).Value = aluno.Nota2;
                    comando.Parameters.Add("@Nota3", SqlDbType.Float).Value = aluno.Nota3;
                    int linhasAfetadas = comando.ExecuteNonQuery();
                    Console.WriteLine($"{linhasAfetadas} linha(s) inserida(s). Aluno salvo com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Erro ao salvar aluno: {ex.Message}");
                    Console.ResetColor();
                }
            }


            public static void ListarAlunos()
            {
                try
                {
                    using var conexao = new SqlConnection(ConectionDB.StringConexao);
                    conexao.Open();
                    const string query = "SELECT Nome, Nota1, Nota2, Nota3 FROM Alunos";
                    using var comando = new SqlCommand(query, conexao);
                    using var reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"Nome: {reader["Nome"]}");
                        Console.WriteLine($"N1:   {reader["Nota1"]}");
                        Console.WriteLine($"N2:   {reader["Nota2"]}");
                        Console.WriteLine($"N3:   {reader["Nota3"]}");
                        Console.WriteLine(new string('-', 20));
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Erro ao listar alunos: {ex.Message}");
                    Console.ResetColor();
                }
            }
        }
        }
    }
}
