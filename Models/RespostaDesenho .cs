using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("drawings_answers")]
    public class RespostaDesenho
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
        
        [Column("conteudo_desenho_id")]
        public int ConteudoDesenhoId { get; set; }
        public virtual ConteudoDesenho ConteudoDesenho { get; set; }
        [Column("opcao_id")]
        public int? OpcaoId { get; set; }
        public virtual Opcao Opcao { get; set; }
        [Column("desenho_id")]
        public int DesenhoId { get; set; }
        public virtual Desenho Desenho { get; set; }
    }
}