using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.DTO;
using Supermarket_system_with_ASP.NET_Core.Data;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class ProdutoController: Controller
    {
        private readonly ApplicationDbContext _database;
        public ProdutoController(ApplicationDbContext database)
        {
            this._database = database;
        }

        [HttpPost]
        public IActionResult Salvar(ProdutoDTO produtoTemporario){
            return Content("Ok");
        }
    }
}