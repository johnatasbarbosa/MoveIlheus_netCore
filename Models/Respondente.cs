using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("respondents")]
    public class Respondente
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("duracao")]
        public TimeSpan Duracao { get; set; }

        public virtual List<Resposta> Respostas { get; set; }
    }
}