using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("PageRestrictions")]
    public class RestricaoPagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual List<RestricaoConteudoPagina> RestricoesConteudosPagina { get; set; }

        public int PaginaId { get; set; }
        public int ProximaPaginaId { get; set; }

        public virtual Pagina Pagina { get; set; }
        //public virtual Pagina ProximaPagina { get; set; }
    }
}