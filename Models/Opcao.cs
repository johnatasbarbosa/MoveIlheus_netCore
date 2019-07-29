using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Options")]
    public class Opcao
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int Valor { get; set; }

        public virtual List<OpcaoResposta> OpcoesResposta { get; set; }

        public int? ConteudoId { get; set; }
        public virtual Conteudo Conteudo { get; set; }

        public int? ConteudoDesenhoId { get; set; }
        public virtual ConteudoDesenho ConteudoDesenho { get; set; }
    }
}