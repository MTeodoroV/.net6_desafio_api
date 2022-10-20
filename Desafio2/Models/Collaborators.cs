using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models
{
    [Table("Colaborador")]
    public class Collaborators
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Name { get; set; }

        [Column("dataCriacao")]
        public DateTime create_at { get; set; }
    }
}