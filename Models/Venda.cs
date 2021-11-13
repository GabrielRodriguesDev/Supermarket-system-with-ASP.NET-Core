using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_system_with_ASP.NET_Core.Models
{
    public class Venda
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }


        public float Total { get; set; }

        public float Pago { get; set; }

        public float Troco { get; set; }

        
    }
}