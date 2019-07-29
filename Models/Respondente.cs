using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Respondents")]
    public class Respondente
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public TimeSpan Duracao { get; set; }

        public virtual List<Resposta> Respostas { get; set; }
    }
}