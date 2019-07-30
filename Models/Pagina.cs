using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("pages")]
    public class Pagina
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("dimensao")]
        public int Dimensao { get; set; }
        [Column("final")]
        public bool Final { get; set; }
        [Column("sequencia")]
        public int Sequencia { get; set; }

        [Column("latitude")]
        public double Latitude { get; set; }
        [Column("longitude")]
        public double Longitude { get; set; }
        [Column("zoom_level")]
        public int ZoomLevel { get; set; }

        public virtual List<Conteudo> Conteudos { get; set; }
        public virtual List<RestricaoPagina> Restricoes { get; set; }

        [Column("formulario_id")]
        public int FormularioId { get; set; }
        public virtual Formulario Formulario { get; set; }
        [Column("proxima_pagina_id")]
        public int? ProximaPaginaId { get; set; }
        public virtual Pagina ProximaPagina { get; set; }

    }
}