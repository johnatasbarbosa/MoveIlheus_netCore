using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("answer_options")]
    public class OpcaoResposta
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("valor")]
        public int Valor { get; set; }

        [Column("resposta_id")]
        public int? RespostaId { get; set; }
        public virtual Resposta Resposta { get; set; }
        [Column("resposta_desenho_id")]
        public int? RespostaDesenhoId { get; set; }
        public virtual RespostaDesenho RespostaDesenho { get; set; }
        [Column("opcao_id")]
        public int? OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
    }
}