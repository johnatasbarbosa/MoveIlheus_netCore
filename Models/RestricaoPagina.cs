using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("page_restrictions")]
    public class RestricaoPagina
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }

        public virtual List<RestricaoConteudoPagina> RestricoesConteudosPagina { get; set; }

        [Column("pagina_id")]
        public int PaginaId { get; set; }
        [Column("proxima_pagina_id")]
        public int ProximaPaginaId { get; set; }

        public virtual Pagina Pagina { get; set; }
        //public virtual Pagina ProximaPagina { get; set; }
    }
}