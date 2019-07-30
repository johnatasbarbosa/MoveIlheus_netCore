using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("coordinates")]
    public class Coordenada
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("latitude")]
        public double Latitude { get; set; }
        [Column("longitude")]
        public double Longitude { get; set; }
        
        [Column("desenho_id")]
        public int DesenhoId { get; set; }
        public virtual Desenho Desenho { get; set; }
    }
}