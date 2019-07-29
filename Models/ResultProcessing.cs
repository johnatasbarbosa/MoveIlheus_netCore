using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoveIlheus.Models
{
    public class ResultProcessing
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public List<int> Ids { get; set; }
        public List<int> Ids2 { get; set; }
    }
}