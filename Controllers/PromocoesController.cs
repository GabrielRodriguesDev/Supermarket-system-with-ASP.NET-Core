using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.DTO;
using Supermarket_system_with_ASP.NET_Core.Models;
using Supermarket_system_with_ASP.NET_Core.Data;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class PromocoesController: Controller
    {
        private readonly ApplicationDbContext _database;
        public PromocoesController(ApplicationDbContext database)
        {
            this._database = database;
        }
        
        [HttpPost]
        public IActionResult Salvar(PromocaoDTO promocaoTemporaria) {

            if(ModelState.IsValid){
                Promocao promocao = new Promocao();
                promocao.Nome = promocaoTemporaria.Nome;
                promocao.Produto = this._database.Produtos.First(produto => produto.Id == promocaoTemporaria.ProdutoID);
                promocao.Porcentagem = promocaoTemporaria.Porcentagem;
                this._database.Promocoes.Add(promocao);
                this._database.SaveChanges();
                return RedirectToAction("Promocoes","Gestao");
            } else {
                ViewBag.Produtos = this._database.Produtos.ToList();
                return View("../Gestao/NovaPromocao");
            }
            
        }
    }
}