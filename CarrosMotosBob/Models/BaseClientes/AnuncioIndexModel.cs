using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosMotosBob.Models.BaseClientes
{
    public class AnuncioIndexModel
    {
        public IEnumerable<AnuncioIndexListingModel> Anuncios { get; set; }
    }
}
