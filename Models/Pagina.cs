using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Pages")]
    public class Pagina
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Dimensao { get; set; }
        public bool Final { get; set; }
        public int Sequencia { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int ZoomLevel { get; set; }

        public virtual List<Conteudo> Conteudos { get; set; }
        public virtual List<RestricaoPagina> Restricoes { get; set; }

        public int FormularioId { get; set; }
        public virtual Formulario Formulario { get; set; }
        public int? ProximaPaginaId { get; set; }
        public virtual Pagina ProximaPagina { get; set; }

    }
}