using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMBData.Models
{
    public class Anuncio
    {
        public int Id { get; set; }

        [Required] public Cliente Anunciante { get; set; }

        [Required] public int Ano { get; set; }

        [Required] public Modelo Modelo { get; set; }

        [Required] public string Descricao { get; set; }

        [Range(1, 3)] public int Status { get; set; }
    }
}