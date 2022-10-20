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

            static List<Collaborators> Collaborators()
            {
                return new List<Collaborators>{
                new Collaborators{Name = "Thomas A. Anderson"},
                new Collaborators{Name = "Dio Brando"},
                new Collaborators{Name = "Luke Skywalker"},
                new Collaborators{Name = "Frodo Baggins"},
                new Collaborators{Name = "Trinity"},
                new Collaborators{Name = "Leia Organa"},
                new Collaborators{Name = "Galadriel"},
                new Collaborators{Name = "Morpheus"},
                new Collaborators{Name = "James Bond"},
                new Collaborators{Name = "Sauron"},
            };
            }


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
                        Console.WriteLine("=========================================\n");

                        switch (choice)
                        {
                            case "sim":
                                Console.WriteLine("Digite [adicionar] para adicionar colaboradores ou digite [listar] para mostrar todos os colaboradores: ");
                                break;

                            case "adicionar":
                                String insert = @"INSERT INTO collaborators(Nome)Values(@NAME)";

                                foreach (Collaborators item in Collaborators())
                                {
                                    if (item.Name == null)
                                    {
                                        Console.WriteLine("Erro ao tentar buscar o nome na lista");
                                    }
                                    else
                                    {
                                        SqlCommand command = new SqlCommand(insert, connection);
                                        command.Parameters.AddWithValue("@NAME", item.Name.ToString());
                                        command.ExecuteNonQuery();
                                    }
                                }
                                Console.WriteLine("Adição concluida");
                                break;

                            case "listar":
                                String list = "SELECT Id, Nome, Created_at FROM collaborators";
                                using (SqlCommand command = new SqlCommand(list, connection))
                                {
                                    using (SqlDataReader reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            Console.WriteLine("Id: {0} | Nome: {1} | Data de criação: {2}", reader.GetInt32(0), reader.GetString(1), reader.GetSqlDateTime(2));
                                        }
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("Comando não reconhecido");
                                break;
                        }

                        Console.WriteLine("=========================================\n");
                        Console.WriteLine("Deseja continuar? [sim/nao]");
                        choice = Console.ReadLine();
                        Console.WriteLine("\n");

                    } while (choice == "sim");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao tentar conectar ao banco de dados");
            }
        }
    }
}