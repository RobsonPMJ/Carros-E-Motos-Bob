using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMBData.Models
{
    public class Compra
    {
        public int Id { get; set; }

        [Required] public int CompradorId { get; set; }
        [Required] public int AnuncioId { get; set; }
    }
}