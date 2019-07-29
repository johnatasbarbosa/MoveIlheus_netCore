﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    [Table("Forms")]
    public class Formulario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual List<Pagina> Paginas { get; set; }
    }
}