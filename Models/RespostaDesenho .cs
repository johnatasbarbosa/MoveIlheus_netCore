using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("DrawingsAnswers")]
    public class RespostaDesenho
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int Valor { get; set; }
        public bool Marcado { get; set; }

        public virtual List<OpcaoResposta> Opcoes { get; set; }
        
        public int ConteudoDesenhoId { get; set; }
        public virtual ConteudoDesenho ConteudoDesenho { get; set; }
        public int? OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
        public int DesenhoId { get; set; }
        public virtual Desenho Desenho { get; set; }
    }
}