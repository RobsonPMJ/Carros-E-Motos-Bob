using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrosMotosBob.Models.BaseClientes
{
    public class ClientesIndexListingModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string EMail { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}