using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("contents_restrictions_page")]
    public class RestricaoConteudoPagina
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }

        public virtual RestricaoPagina RestricaoPagina { get; set; }
        //public virtual Pagina Pagina { get; set; }
        public virtual Conteudo Conteudo { get; set; }
        public virtual Opcao Opcao { get; set; }
        [Column("restricao_pagina_id")]
        public int RestricaoPaginaId { get; set; }
        //public int PaginaId { get; set; }
        [Column("conteudo_id")]
        public int ConteudoId { get; set; }
        [Column("opcao_id")]
        public int OpcaoId { get; set; }
    }
}