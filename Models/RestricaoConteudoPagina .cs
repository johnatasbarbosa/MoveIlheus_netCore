using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("ContentsRestrictionsPage")]
    public class RestricaoConteudoPagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual RestricaoPagina RestricaoPagina { get; set; }
        //public virtual Pagina Pagina { get; set; }
        public virtual Conteudo Conteudo { get; set; }
        public virtual Opcao Opcao { get; set; }
        public int RestricaoPaginaId { get; set; }
        //public int PaginaId { get; set; }
        public int ConteudoId { get; set; }
        public int OpcaoId { get; set; }
    }
}