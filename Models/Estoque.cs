using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_system_with_ASP.NET_Core.Models
{
    public class Estoque
    {
        public int Id { get; set; }

        public Produto  Produto { get; set; }

        public float Quantidade { get; set; }
    }
}