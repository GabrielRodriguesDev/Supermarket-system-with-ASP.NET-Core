using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.Data;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class GestaoController: Controller
    {
        private readonly ApplicationDbContext _database;

        public GestaoController(ApplicationDbContext database)
        {
            this._database = database;
        }
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

        public IActionResult Produtos(){
            return View();
        }

        public IActionResult NovoProduto(){
            ViewBag.Categorias = this._database.Categorias.ToList();
            ViewBag.Fornecedores = this._database.Fornecedores.ToList();

            return View();
        }
    }
}