using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket_system_with_ASP.NET_Core.DTO
{
    public class CategoriaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100,ErrorMessage = "O nome só pode ter até 100 caracteres.")]
        [MinLength(2, ErrorMessage = "O nome precisa ter mais de 2 caracteres.")]
        public string Nome { get; set; }

    }
}