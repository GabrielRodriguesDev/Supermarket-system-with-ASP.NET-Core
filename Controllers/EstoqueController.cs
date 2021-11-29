using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.Models;
using Supermarket_system_with_ASP.NET_Core.Data;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class EstoqueController: Controller
    {
        private readonly ApplicationDbContext _database;
        public EstoqueController(ApplicationDbContext database)
        {
            this._database = database;
        }
        [HttpPost]
        public IActionResult Salvar(Estoque estoqueTemporario) {
            if(ModelState.IsValid) {
                //Devido a estarmos usando o atributo auxiliar ProdutoId criado direto no model,
                //o EF identifica que o campo auxiliar representa o ID da entidade e automaticamente já faz a busca
                // portanto na hora de salvar já tenho o objeto correto em mãos.
                this._database.Estoque.Add(estoqueTemporario);
                this._database.SaveChanges(); 
                return RedirectToAction("Estoque","Gestao");

            }
            ViewBag.Produtos = this._database.Produtos.Where(produto => produto.Status == true).ToList();
            return View("../Gestao/NovoEstoque");
        }
    }
}