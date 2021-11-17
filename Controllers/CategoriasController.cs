using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.Data;
using Supermarket_system_with_ASP.NET_Core.DTO;
using Supermarket_system_with_ASP.NET_Core.Models;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class CategoriasController: Controller
    {   
        private readonly ApplicationDbContext _database;

        public CategoriasController(ApplicationDbContext database)
        {
            this._database = database;
        }
        [HttpPost]
        public IActionResult Salvar(CategoriaDTO categoriaTemporaria) {
            if(ModelState.IsValid){
                Categoria categoria = new Categoria();
                categoria.Nome = categoriaTemporaria.Nome;
                categoria.Status = true;
                this._database.Categorias.Add(categoria);
                this._database.SaveChanges();
                return RedirectToAction("Categorias","Gestao");
            }else{
                return View("../Gestao/NovaCategoria");
            }
        }
    }
}