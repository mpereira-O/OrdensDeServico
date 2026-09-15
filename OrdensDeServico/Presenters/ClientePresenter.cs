using OrdensDeServico.Data;
using OrdensDeServico.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdensDeServico.Presenters
{
    public class ClientePresenter
    {
        private Contexto db;

        public ClientePresenter()
        {
            db = new Contexto();
            db.Database.EnsureCreated();
        }

        public ClientePresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Cliente> Buscar(string nome)
        {
            return db.Clientes
                .Where(c => c.Nome.ToUpper().Contains(nome.ToUpper()))
                .ToList();
        }

        public bool Cadastrar(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            int linhas = db.SaveChanges();
            return linhas == 1;
        }

        public bool Remover(Cliente cliente)
        {
            db.Clientes.Remove(cliente);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }

        public bool Editar(Cliente cliente)
        {
            db.Clientes.Update(cliente);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }
    }
}