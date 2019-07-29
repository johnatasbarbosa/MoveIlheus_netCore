using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("DrawingsContents")]
    public class ConteudoDesenho
    {
        public int Id { get; set; }
        public TipoConteudo Tipo { get; set; }
        public string Texto { get; set; }
        public int Valor { get; set; }
        public int Sequencia { get; set; }
        public bool Obrigatorio { get; set; }

        public virtual List<Opcao> Opcoes { get; set; }
        public virtual List<RespostaDesenho> Respostas { get; set; }

        public int ConteudoId { get; set; }
        public virtual Conteudo Conteudo { get; set; }
    }
}