using System;
using System.Collections.Generic;
using System.Data;
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
                Id = result.Id,
                Nome = result.Nome,
                Endereco = _clientes.GetEndereco(result.Id),
                CPF = _clientes.GetCPF(result.Id) ,
                EMail = result.Email,
                Telefone = result.Telefone
            });
            var model = new ClienteIndexModel()
            {
                Clientes = listingResults
            };

            return View(model);
        }

        public IActionResult Anuncios(int id)
        {
            var anuncioModels = _clientes.GetAnuncios(id);

            var listingResults = anuncioModels.Select(result => new AnuncioIndexListingModel
            {
                NomeCliente = _clientes.GetNome(id),
                CpfCliente = _clientes.GetCPF(id),
                Ano = result.Ano,
                Modelo = result.Modelo.Nome,
                Descricao = result.Descricao,
                Status = result.Status

            });
            var model = new AnuncioIndexModel()
            {
                Anuncios = listingResults
            };
            return View(model);
        }
    }
}

