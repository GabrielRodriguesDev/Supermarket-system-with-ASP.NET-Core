using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Supermarket_system_with_ASP.NET_Core.Models;

namespace Supermarket_system_with_ASP.NET_Core.DTO
{
    public class PromocaoDTO
    {

        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "Nome só pode ter até 100 caracteres.")]
        [MinLength(3, ErrorMessage ="Nome precisa ter mais de 3 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o produto.")]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "É obrigatório informar a aliquota da promoção.")]
        [Range(0,100, ErrorMessage = "Só é aceito valores entre 0 e 100.")]
        public float Porcentagem { get; set; }

        
    }
}