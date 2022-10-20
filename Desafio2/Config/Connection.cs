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
        static void Main(string[] args)
        {

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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao tentar conectar ao banco de dados");
            }
        }
    }
}