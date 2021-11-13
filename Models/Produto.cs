using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_system_with_ASP.NET_Core.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Categoria Categoria { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public float PrecoDeCusto { get; set; }

        public float PrecoDeVenda { get; set; }

        public int Medicao { get; set; }

        public bool Status { get; set; }
    }
}