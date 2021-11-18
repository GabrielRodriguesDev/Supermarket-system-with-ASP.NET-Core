using System;
using Microsoft.AspNetCore.Mvc;


namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class GestaoController: Controller
    {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Categorias(){
            return View();
        }

        public IActionResult NovaCategoria(){
            return View();
        }

        public IActionResult Fornecedores(){
            return View();
        }

        public IActionResult NovoFornecedor(){
            return View();
        }
    }
}