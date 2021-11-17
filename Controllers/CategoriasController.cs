using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.DTO;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class CategoriasController: Controller
    {   
        [HttpPost]
        public IActionResult Salvar(CategoriaDTO categoriaTemporaria) {
            return Content("Método salvar acessado.");
        }
    }
}