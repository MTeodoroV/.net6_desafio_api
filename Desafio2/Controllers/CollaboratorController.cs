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

        private static List<Collaborators> Deliveries(){
            return new List<Collaborators>{
                new Collaborators{Id = 1, Name = "123"},
                new Collaborators{Id = 2, Name = "456"},
                new Collaborators{Id = 3, Name = "789"},
                new Collaborators{Id = 4, Name = "789"},
                new Collaborators{Id = 5, Name = "789"},
                new Collaborators{Id = 6, Name = "789"},
                new Collaborators{Id = 7, Name = "789"},
                new Collaborators{Id = 8, Name = "789"},
                new Collaborators{Id = 9, Name = "789"},
                new Collaborators{Id = 10, Name = "789"},
            };

        // private readonly Contexto _context;

        // public CollaboratorController(Contexto context)
        // {
        //     _context = context;
        // }


        // public async Task<IActionResult> listar()
        //     {
        //         return View(await _context.Produto.ToListAsync());
        //     }


        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // public async Task<IActionResult> Insert(Delivery delivery)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(delivery);
        //         await _context.SaveChangesAsync();
        //         return _context;
        //     }
        //     return View(delivery);
        // }
        }
    }
}