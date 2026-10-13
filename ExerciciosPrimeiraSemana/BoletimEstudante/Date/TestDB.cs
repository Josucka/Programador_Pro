using Microsoft.Data.SqlClient;

namespace ExerciciosPrimeiraSemana.BoletimEstudante.Date
{
    internal class TestDB
    {
        public static void CriarBancoETabela()
        {
            using var conn = new SqlConnection(ConectionDB.StringConexao);
            conn.Open();
            // Cria o banco caso ainda não exista
            using (var cmd = new SqlCommand(
                @"IF DB_ID('JosuckDB') IS NULL CREATE DATABASE JosuckDB;", conn))
            {
                cmd.ExecuteNonQuery();
            }
            // Usa o banco criado
            using (var cmd = new SqlCommand("USE JosuckDB;", conn))
            {
                cmd.ExecuteNonQuery();
            }
            // Cria a tabela Alunos caso ainda não exista
            using (var cmd = new SqlCommand(@"
                IF OBJECT_ID('dbo.Alunos') IS NULL
                CREATE TABLE dbo.Alunos (
                    Id    INT IDENTITY(1,1) PRIMARY KEY,
                    Nome  NVARCHAR(100) NOT NULL,
                    Nota1 FLOAT NOT NULL,
                    Nota2 FLOAT NOT NULL,
                    Nota3 FLOAT NOT NULL
                );", conn))
            {
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Banco e tabela garantidos.");
        }

        public static void TestarConexao()
        {
            try
            {
                using var conn = new SqlConnection(ConectionDB.StringConexao);
                conn.Open();
                Console.WriteLine("Conexão OK!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha na conexão: {ex.Message}");
            }
        }
    }
}
