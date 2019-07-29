using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Contents")]
    public class Conteudo
    {
        public int Id { get; set; }
        public TipoConteudo Tipo { get; set; }
        public string Texto { get; set; }
        public int Valor { get; set; }
        public int Sequencia { get; set; }
        public bool Obrigatorio { get; set; }

        public string TituloConteudosDesenho { get; set; }
        public string MensagemNovoDesenho { get; set; }

        public virtual List<Opcao> Opcoes { get; set; }
        public virtual List<RestricaoConteudo> Restricoes { get; set; }
        public virtual List<Resposta> Respostas { get; set; }
        public virtual List<ConteudoDesenho> ConteudosDesenhos { get; set; }
        //public virtual List<PaginaDesenho> PaginasDesenho { get; set; }

        public int PaginaId { get; set; }
        public virtual Pagina Pagina { get; set; }
        //public int? PaginaDesenhoId { get; set; }
        //public virtual PaginaDesenho PaginaDesenho { get; set; }
    }
}