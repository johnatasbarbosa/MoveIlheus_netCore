using MoveIlheus.Models;
using System;
using System.Linq;

namespace MoveIlheus.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MoveIlheusContexto context)
        {
            context.Database.EnsureCreated();
        }
    }
}