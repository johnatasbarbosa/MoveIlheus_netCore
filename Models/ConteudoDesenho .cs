using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("drawings_contents")]
    public class ConteudoDesenho
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("tipo")]
        public TipoConteudo Tipo { get; set; }
        [Column("texto")]
        public string Texto { get; set; }
        [Column("valor")]
        public int Valor { get; set; }
        [Column("sequencia")]
        public int Sequencia { get; set; }
        [Column("obrigatorio")]
        public bool Obrigatorio { get; set; }

        public virtual List<Opcao> Opcoes { get; set; }
        public virtual List<RespostaDesenho> Respostas { get; set; }

        [Column("conteudo_id")]
        public int ConteudoId { get; set; }
        public virtual Conteudo Conteudo { get; set; }
    }
}