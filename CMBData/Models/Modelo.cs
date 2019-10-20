using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMBData.Models
{
    public class Modelo
    {
        public int Id { get; set; }

        [Required] public string Nome { get; set; }

        [Range(0, 5)] public int Avaliacao { get; set; }

        public int NumeroDePesquisas { get; set; }
    }
}