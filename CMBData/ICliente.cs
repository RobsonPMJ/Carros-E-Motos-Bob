using System;
using System.Collections.Generic;
using System.Text;
using CMBData.Models;

namespace CMBData
{
    public interface ICliente
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
        HistoricoCompras GetHistoricoCompras(int id);
        AnunciosAbertos GetAnunciosAbertos(int id);
        void Add(Cliente newCliente);
        string GetNome(int id);
        string GetEndereco(int id);
        string GetEMail(int id);
        string GetTelefone(int id);
        int GetCPF(int id);
    }
}
