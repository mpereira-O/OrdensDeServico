using OrdensDeServico.Data;
using OrdensDeServico.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrdensDeServico.Presenters
{
    public class TecnicoPresenter
    {
        Contexto db;

        public TecnicoPresenter()
        {
            this.db = new Contexto(); 
        }
        public TecnicoPresenter(Contexto db)
        {
            this.db = db;
        }

        public List<Tecnico> Buscar(string filtro)
        {
            return db.Tecnicos
              .Where(o => o.Nome.ToUpper().Contains(filtro.ToUpper()) ||
                          o.Especialidade.ToUpper().Contains(filtro.ToUpper()))
              .ToList();
        }

        public List<OrdemServico> BuscarServico(string filtro)
        {
            return db.OrdensServico
               .Include(o => o.Cliente)
               .Include(o => o.Tecnico)
               .Where(o => o.DescricaoProblema.ToUpper().Contains(filtro.ToUpper()) ||
                           o.Cliente.Nome.ToUpper().Contains(filtro.ToUpper()))
               .ToList();
        }
        public bool Cadastrar(Tecnico tecnico)
        {
            db.Tecnicos.Add(tecnico);
            int linhas = db.SaveChanges();
            return linhas == 1;
        }

        public bool Remover(Tecnico tecnico)
        {
            db.Tecnicos.Remove(tecnico);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }

        public bool Editar(Tecnico tecnico)
        {
            db.Tecnicos.Update(tecnico);
            int linhas = db.SaveChanges();
            return linhas > 0;
        }
    }
}
