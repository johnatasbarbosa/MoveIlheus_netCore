using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("AnswerOptions")]
    public class OpcaoResposta
    {
        public int Id { get; set; }
        public int Valor { get; set; }

        public int? RespostaId { get; set; }
        public virtual Resposta Resposta { get; set; }
        public int? RespostaDesenhoId { get; set; }
        public virtual RespostaDesenho RespostaDesenho { get; set; }
        public int? OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
    }
}