using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_system_with_ASP.NET_Core.DTO
{
    public class ProdutoDTO
    {

        [Required]
        public int Id { get; set; } 


        [Required(ErrorMessage ="Nome do produto é obrigatório.")]
        [StringLength(100,ErrorMessage = "Nome do produto tem que ter menos de 100 caracteres")]
        [MinLength(2,ErrorMessage ="Nome do produto tem que conter um tamanho maior do que 2 caracteres ")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Categoria do produto é obrigatória.")]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage ="Fornecedor do produto é obrigatória.")]
        public int  FornecedorID { get; set; }

        [Required(ErrorMessage ="O preço de custo do produto é obrigatório.")]
        public float PrecoDeCusto { get; set; }
        
        [Required(ErrorMessage ="O preço de custo do produto é obrigatório.")]
        public String PrecoDeCustoString { get; set; }
        [Required(ErrorMessage ="O preço de venda do produto é obrigatório.")]
        public float PrecoDeVenda { get; set; }

        [Required(ErrorMessage ="O preço de venda do produto é obrigatório.")]
        public String PrecoDeVendaString { get; set; }

        [Required(ErrorMessage ="A medição do produto é obrigatória.")]
        [Range(0,2, ErrorMessage = "Medição inválida.")]
        public int Medicao { get; set; }

        public bool Status { get; set; }
    }
}