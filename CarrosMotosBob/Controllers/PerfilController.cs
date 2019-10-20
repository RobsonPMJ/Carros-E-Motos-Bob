using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMBData;
using Microsoft.AspNetCore.Mvc;

namespace CarrosMotosBob.Controllers
{
    public class PerfilController : Controller
    {
        ICliente _clientes;
        public PerfilController(ICliente clientes)
        {

            _clientes = clientes;

        }

        public IActionResult Index()
        {
            return null;
        }
    }
}
