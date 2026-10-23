using ExerciciosPrimeiraSemana.Config;
using Microsoft.Data.SqlClient;
using System.Data.Entity;

namespace ExerciciosPrimeiraSemana.BoletimEstudante.Date
{
    // Classe responsável por criar o banco de dados e a tabela Alunos, caso ainda não existam.
    //chamada de TestDB.CriarBancoETabela() no Program.cs garante que o banco e a tabela existam antes de qualquer operação.
    internal class TestDB
    {
        // Método que cria o banco de dados JosuckDB e a tabela Alunos, caso ainda não existam.
        public static void CriarBancoETabela()
        {
            using var conn = new SqlConnection(Configuracao.ConnectionString);
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

        // Método que testa a conexão com o banco de dados.
        public static void TestarConexao()
        {
            try
            {
                // Tenta abrir a conexão com o banco de dados usando a string de conexão definida em Configuracao.ConnectionString
                using var conn = new SqlConnection(Configuracao.ConnectionString);
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
