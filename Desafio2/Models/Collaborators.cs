using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models
{
    public class Collaborators
    {
        [Column("nome")]
        public string? Name { get; set; }
    }
}