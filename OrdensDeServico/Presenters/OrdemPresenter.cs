using OrdensDeServico.Data;
using OrdensDeServico.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdensDeServico.Presenters
{
    public class OrdemPresenter
    {
        Contexto db;

        public OrdemPresenter()
        {
            this.db = new Contexto();
        }

        public OrdemPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<OrdemServico> Buscar(string filtro)
        {
            return db.OrdensServico
                .Include(o => o.Cliente)
                .Include(o => o.Tecnico)
                .Where(o => o.DescricaoProblema.ToUpper().Contains(filtro.ToUpper()) ||
                            o.Cliente.Nome.ToUpper().Contains(filtro.ToUpper()))
                .ToList();
        }

        public List<Cliente> BuscarClientes(string filtro)
        {
            return db.Clientes
                .Where(o => o.Nome.ToUpper().Contains(filtro.ToUpper()) ||
                            o.Telefone.ToUpper().Contains(filtro.ToUpper()))
                .ToList();
        }

        public List<Tecnico> BuscarTecnicos(string filtro)
        {
            return db.Tecnicos
                .Where(o => o.Nome.ToUpper().Contains(filtro.ToUpper()) ||
                            o.Especialidade.ToUpper().Contains(filtro.ToUpper()))
                .ToList();
        }

        public bool Cadastrar(OrdemServico ordem)
        {
            db.OrdensServico.Add(ordem);
            int linhas = db.SaveChanges();
            return linhas == 1;
        }

        public bool Remover(OrdemServico ordem)
        {
            db.OrdensServico.Remove(ordem);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }

        public bool Editar(OrdemServico ordem)
        {
            db.OrdensServico.Update(ordem);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }
    }
}