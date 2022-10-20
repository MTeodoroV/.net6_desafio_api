using System.Collections.Immutable;
using System;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Desafio2.Models;
using Microsoft.Data.SqlClient;

namespace AddCollaborators
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;




            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "konia-desafio.database.windows.net";
                builder.UserID = "koniaDesafio";
                builder.Password = "KoniaKonia12";
                builder.InitialCatalog = "konia-desafio";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("=========================================\n");
                    connection.Open(); 
                    Console.WriteLine("Conectado ao banco de dados\n");
                    Console.WriteLine("=========================================\n");
                    do
                    {
                        Console.WriteLine("Digite [adicionar] para adicionar colaboradores ou digite [listar] para mostrar todos os colaboradores: ");
                        choice = Console.ReadLine();

                        switch (choice)
                        {
                            case "sim":
                                Console.WriteLine("Digite [adicionar] para adicionar colaboradores ou digite [listar] para mostrar todos os colaboradores: ");
                                break;

                            case "adicionar":
                                Console.WriteLine("Adicionando");
                                break;

                            case "listar":
                                String sql = "SELECT Id, Nome, Created_at from teste";
                                using (SqlCommand command = new SqlCommand(sql, connection))
                                    {
                                        using (SqlDataReader reader = command.ExecuteReader())
                                        {
                                            while (reader.Read())
                                            {
                                                Console.WriteLine("Id: {0}, Nome: {1}, Data de criação: {2}", reader.GetInt32(0), reader.GetString(1), reader.GetSqlDateTime(2));
                                            }
                                        }
                                    } 
                                break;

                            default:
                                Console.WriteLine("Comando não reconhecido");
                                break;
                        }

                        Console.WriteLine("Deseja sair: [sim/nao]");
                        choice = Console.ReadLine();

                    } while (choice == "nao");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao tentar conectar ao banco de dados");
            }
        }
    }
}