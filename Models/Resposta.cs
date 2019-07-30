using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("answers")]
    public class Resposta
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("texto")]
        public string Texto { get; set; }
        [Column("valor")]
        public int Valor { get; set; }
        [Column("marcado")]
        public bool Marcado { get; set; }

        public virtual List<OpcaoResposta> Opcoes { get; set; }
        public virtual List<Desenho> Desenhos { get; set; }

        [Column("conteudo_id")]
        public int ConteudoId { get; set; }
        public virtual Conteudo Conteudo { get; set; }
        [Column("opcao_id")]
        public int? OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
        [Column("respondente_id")]
        public int RespondenteId { get; set; }
        public virtual Respondente Respondente { get; set; }
    }
}