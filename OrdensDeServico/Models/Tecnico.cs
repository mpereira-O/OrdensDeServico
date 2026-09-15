using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrdensDeServico.Models
{
    [Table("tecnicos")]
    public class Tecnico
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("especialidade")]
        public string Especialidade { get; set; }

        public List<OrdemServico> OrdemServicos { get; set; }
    }
}