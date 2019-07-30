using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("content_restrictions")]
    public class RestricaoConteudo
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }

        public virtual Conteudo Conteudo { get; set; }
        //public virtual Pagina PaginaAlvo { get; set; }
        //public virtual Conteudo ConteudoAlvo { get; set; }
        //public virtual Opcao OpcaoAlvo { get; set; }
        [Column("conteudo_id")]
        public int ConteudoId { get; set; }
        [Column("pagina_alvo_id")]
        public int PaginaAlvoId { get; set; }
        [Column("conteudo_alvo_id")]
        public int ConteudoAlvoId { get; set; }
        [Column("opcao_alvo_id")]
        public int OpcaoAlvoId { get; set; }
        
        //public RestricaoPagina RestricaoPagina { get; set; }
        //public int RestricaoPaginaId { get; set; }
    }
}