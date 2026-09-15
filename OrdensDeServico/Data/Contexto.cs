using Microsoft.EntityFrameworkCore;
using OrdensDeServico.Models;
using System;

namespace OrdensDeServico.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<OrdemServico> OrdensServico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;" +
                                      "Port=5432;Database=ordens_de_servico;" +
                                      "Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed de Clientes
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente { Id = 1, Nome = "Carlos Silva", Telefone = "(14) 99888-1122" },
                new Cliente { Id = 2, Nome = "Mariana Oliveira", Telefone = "(14) 99777-3344" },
                new Cliente { Id = 3, Nome = "Tech Solutions LTDA", Telefone = "(14) 3221-5500" }
            );

            // Seed de Técnicos
            modelBuilder.Entity<Tecnico>().HasData(
                new Tecnico { Id = 1, Nome = "Roberto Alves", Especialidade = "Hardware & Notebooks" },
                new Tecnico { Id = 2, Nome = "Fernanda Costa", Especialidade = "Redes & Servidores" }
            );

            // Seed de Ordens de Serviço
            modelBuilder.Entity<OrdemServico>().HasData(
                new OrdemServico
                {
                    Id = 1,
                    // Adicionado DateTimeKind.Utc
                    DataAbertura = new DateTime(2026, 3, 10, 9, 30, 0, DateTimeKind.Utc),
                    DescricaoProblema = "Notebook não liga após queda de energia",
                    ValorTotal = 250.00m,
                    Status = "Pendente",
                    ClienteId = 1,
                    TecnicoId = 1
                },
                new OrdemServico
                {
                    Id = 2,
                    // Adicionado DateTimeKind.Utc
                    DataAbertura = new DateTime(2026, 3, 11, 14, 0, 0, DateTimeKind.Utc),
                    DescricaoProblema = "Configuração de Roteador Wi-Fi Corporativo",
                    ValorTotal = 180.00m,
                    Status = "Em Andamento",
                    ClienteId = 3,
                    TecnicoId = 2
                }
            );
        }
    }
}