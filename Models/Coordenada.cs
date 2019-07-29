using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Coordinates")]
    public class Coordenada
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        public int DesenhoId { get; set; }
        public virtual Desenho Desenho { get; set; }
    }
}