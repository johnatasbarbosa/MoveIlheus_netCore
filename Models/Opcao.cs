using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("options")]
    public class Opcao
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("texto")]
        public string Texto { get; set; }
        [Column("valor")]
        public int Valor { get; set; }

        public virtual List<OpcaoResposta> OpcoesResposta { get; set; }

        [Column("conteudo_id")]
        public int? ConteudoId { get; set; }
        public virtual Conteudo Conteudo { get; set; }

        [Column("conteudo_desenho_id")]
        public int? ConteudoDesenhoId { get; set; }
        public virtual ConteudoDesenho ConteudoDesenho { get; set; }
    }
}