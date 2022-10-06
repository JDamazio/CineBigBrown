using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace API.Models
{
    public class Cartaz
    {
        public int CartazID { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string MovieName { get; set; }
        public DateTime Date { get; set; }
        [Range(
            10,
            300,
            ErrorMessage = "O valor deve estar entre R$ 10,00 e R$ 300,00"
        )]
        public double value { get; set; }
    }
}