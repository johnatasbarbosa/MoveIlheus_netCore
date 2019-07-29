using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("ContentRestrictions")]
    public class RestricaoConteudo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual Conteudo Conteudo { get; set; }
        //public virtual Pagina PaginaAlvo { get; set; }
        //public virtual Conteudo ConteudoAlvo { get; set; }
        //public virtual Opcao OpcaoAlvo { get; set; }
        public int ConteudoId { get; set; }
        public int PaginaAlvoId { get; set; }
        public int ConteudoAlvoId { get; set; }
        public int OpcaoAlvoId { get; set; }
        
        //public RestricaoPagina RestricaoPagina { get; set; }
        //public int RestricaoPaginaId { get; set; }
    }
}