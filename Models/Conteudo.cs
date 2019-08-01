using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("contents")]
    public class Conteudo
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

        [Column("titulo_conteudos_desenho")]
        public string TituloConteudosDesenho { get; set; }
        [Column("mensagem_novo_desenho")]
        public string MensagemNovoDesenho { get; set; }

        public virtual List<Opcao> Opcoes { get; set; }
        public virtual List<RestricaoConteudo> Restricoes { get; set; }
        public virtual List<Resposta> Respostas { get; set; }
        public virtual List<ConteudoDesenho> ConteudosDesenhos { get; set; }
        //public virtual List<PaginaDesenho> PaginasDesenho { get; set; }

        [Column("pagina_id")]
        public int PaginaId { get; set; }
        public virtual Pagina Pagina { get; set; }
        //public int? PaginaDesenhoId { get; set; }
        //public virtual PaginaDesenho PaginaDesenho { get; set; }
    }
}