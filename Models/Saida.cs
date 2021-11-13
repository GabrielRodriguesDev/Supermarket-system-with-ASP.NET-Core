using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_system_with_ASP.NET_Core.Models
{
    public class Saida
    {
        public int Id { get; set; }

        public Produto  Produto { get; set; }

        public float ValorDaVenda { get; set; }

        public DateTime Data { get; set; }

    }
}