using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrdensDeServico.Models
{
    [Table("ordens_servico")]
    public class OrdemServico
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("data_abertura")]
        public DateTime DataAbertura { get; set; }

        [Column("descricao_problema")]
        public string DescricaoProblema { get; set; }

        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [ForeignKey(nameof(ClienteId))]
        public Cliente Cliente { get; set; }

        [Column("tecnico_id")]
        public int TecnicoId { get; set; }

        [ForeignKey(nameof(TecnicoId))]
        public Tecnico Tecnico { get; set; }
    }
}