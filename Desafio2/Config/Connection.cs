using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio2.Models;
using Microsoft.Data.SqlClient;

namespace Desafio2.Config
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();

        public SqlConnection conectar()
        {
            // con.ConnectionString = "Server=tcp:konia-desafio.database.windows.net,1433;Initial Catalog=konia-desafio;Persist Security Info=False;User ID=koniaDesafio;Password=KoniaKonia12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "konia-desafio.database.windows.net";
            builder.UserID = "koniaDesafio";
            builder.Password = "KoniaKonia12";
            builder.InitialCatalog = "konia-desafio";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    Console.WriteLine("=========================================\n");
                    Console.WriteLine("Conectado ao banco de dados\n");
                    Console.WriteLine("=========================================\n");
                    connection.Open();
                }
                return connection;
            }
        }

        public void teste()
        {
            String sql = "SELECT Id, Nome, Created_at from teste";

            using (SqlCommand command = new SqlCommand(sql, conectar()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Teste");
                    while (reader.Read())
                    {
                        Console.WriteLine("Id: {0}, Nome: {1}, Data de criação: {2}", reader.GetInt32(0), reader.GetString(1), reader.GetSqlDateTime(2));
                    }
                }
            }
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        // SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        // builder.DataSource = "konia-desafio.database.windows.net";
        //             builder.UserID = "koniaDesafio";
        //             builder.Password = "KoniaKonia12";
        //             builder.InitialCatalog = "konia-desafio";

        // using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
        // {
        //     Console.WriteLine("=========================================\n");
        //     Console.WriteLine("Conectado ao banco de dados\n");
        //     Console.WriteLine("=========================================\n");
        //     connection.Open();
        // }
    }
}
