using System;
using System.Collections.Generic;
using System.Linq;
using CMBData;
using CMBData.Models;
using Microsoft.EntityFrameworkCore;

namespace CMBServices
{
    public class ClienteServices : ICliente
    {
        CMBContext _context;

        public ClienteServices(CMBContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes.Include(asset => asset.HistoricoCompras).Include(asst => asst.Anuncios);
        }

        public Cliente GetById(int id)
        {
            return _context.Clientes
                .Include(asst => asst.HistoricoCompras)
                .Include(asset => asset.Anuncios)
                .FirstOrDefault(asset => asset.ClienteId == id);
        }

        public HistoricoCompras GetHistoricoCompras(int id)
        {
            return GetById(id).HistoricoCompras;
        }

        public AnunciosAbertos GetAnunciosAbertos(int id)
        {
            return GetById(id).Anuncios;
        }

        public void Add(Cliente newCliente)
        {
            _context.Add(newCliente);
            _context.SaveChanges();
        }

        public string GetNome(int id)
        {
            return GetById(id).Nome;
        }

        public string GetEndereco(int id)
        {
            return GetById(id).Cidade + GetById(id).Estado;
        }

        public string GetEMail(int id)
        {
            return GetById(id).Email;
        }

        public string GetTelefone(int id)
        {
            return GetById(id).Telefone;
        }

        public int GetCPF(int id)
        {
            return GetById(id).CPF;
        }
    }
}