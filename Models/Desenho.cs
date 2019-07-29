using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Drawings")]
    public class Desenho
    {
        public int Id { get; set; }
        public TipoDesenho Tipo { get; set; }

        public virtual List<Coordenada> Coordenadas { get; set; }
        public virtual List<RespostaDesenho> RespostasDesenho { get; set; }

        public int RespostaId { get; set; }
        public virtual Resposta Resposta { get; set; }
    }
}