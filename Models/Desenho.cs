using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("drawings")]
    public class Desenho
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("tipo")]
        public TipoDesenho Tipo { get; set; }

        public virtual List<Coordenada> Coordenadas { get; set; }
        public virtual List<RespostaDesenho> RespostasDesenho { get; set; }

        [Column("resposta_id")]
        public int RespostaId { get; set; }
        public virtual Resposta Resposta { get; set; }
    }
}