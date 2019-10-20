using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarrosMotosBob.Models.BaseClientes;
using CMBData;
using Microsoft.AspNetCore.Mvc;

namespace CarrosMotosBob.Controllers
{
    public class BaseClientesController : Controller
    {
        ICliente _clientes;

        public BaseClientesController(ICliente clientes)
        {
            _clientes = clientes;
        }

        public IActionResult Index()
        {
            var clienteModels = _clientes.GetAll();

            var listingResults = clienteModels.Select(result => new ClientesIndexListingModel
            {
                Id = result.ClienteId,
                Nome = result.Nome,
                Endereco = _clientes.GetEndereco(result.ClienteId),
                CPF = _clientes.GetCPF(result.ClienteId) ,
                EMail = result.Email,
                Telefone = result.Telefone
            });
            var model = new ClienteIndexModel()
            {
                Clientes = listingResults
            };

            return View(model);
        }
    }
}

