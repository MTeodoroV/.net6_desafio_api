using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio2.Models;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Mvc;

namespace Desafio2.Controllers
{
    // [apiController]
    public class CollaboratorController
    {

        public static List<Collaborators> Collaborators()
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

        public static string listar()
        {
            foreach (Collaborators item in Collaborators())
            {
                if (item.Name == null)
                {
                    Console.WriteLine("Erro ao tentar buscar os nomes na lista");
                }
                else
                {
                    Console.WriteLine(item.Name);
                }
            }
            return "";
        }
    }
}