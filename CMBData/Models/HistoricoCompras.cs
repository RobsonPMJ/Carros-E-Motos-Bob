using System;
using System.Collections.Generic;
using System.Text;

namespace CMBData.Models
{
    public class HistoricoCompras
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Anuncio Compra { get; set; }
    }
}