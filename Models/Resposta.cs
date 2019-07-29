using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Answers")]
    public class Resposta
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public int Valor { get; set; }
        public bool Marcado { get; set; }

        public virtual List<OpcaoResposta> Opcoes { get; set; }
        public virtual List<Desenho> Desenhos { get; set; }

        public int ConteudoId { get; set; }
        public virtual Conteudo Conteudo { get; set; }
        public int? OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
        public int RespondenteId { get; set; }
        public virtual Respondente Respondente { get; set; }
    }
}