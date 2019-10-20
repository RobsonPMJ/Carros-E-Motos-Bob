using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CMBData.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required] public string Nome { get; set; }
        [Required] public string Cidade { get; set; }
        [Required] public string Estado { get; set; }
        [Required] public int CPF { get; set; }
        [Required] public string Email { get; set; }
        [Required] public string Telefone { get; set; }
        public HistoricoCompras HistoricoCompras { get; set; }
        public AnunciosAbertos Anuncios { get; set; }
    }
}