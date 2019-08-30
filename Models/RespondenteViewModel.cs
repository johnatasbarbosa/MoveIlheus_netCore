using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    public class RespondenteViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        public virtual List<Resposta> Respostas { get; set; }
    }
}