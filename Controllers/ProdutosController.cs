using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.DTO;
using Supermarket_system_with_ASP.NET_Core.Data;
using Supermarket_system_with_ASP.NET_Core.Models;

namespace Supermarket_system_with_ASP.NET_Core.Controllers
{
    public class ProdutosController: Controller
    {
        private readonly ApplicationDbContext _database;
        public ProdutosController(ApplicationDbContext database)
        {
            this._database = database;
        }

        [HttpPost]
        public IActionResult Salvar(ProdutoDTO produtoTemporario){
            if(ModelState.IsValid){
                Produto produto = new Produto();
                produto.Nome = produtoTemporario.Nome;
                produto.Categoria = this._database.Categorias.First(categoria => categoria.Id == produtoTemporario.CategoriaID);
                produto.Fornecedor = this._database.Fornecedores.First(fornecedor => fornecedor.Id == produtoTemporario.FornecedorID);
                produto.PrecoDeCusto = produtoTemporario.PrecoDeCusto;
                produto.PrecoDeVenda = produtoTemporario.PrecoDeVenda; 
                produto.Medicao = produtoTemporario.Medicao;
                produto.Status = true;
                this._database.Produtos.Add(produto);
                this._database.SaveChanges(); 
                return RedirectToAction("Produtos","Gestao");
                
            }else{
                
                ViewBag.Categorias = this._database.Categorias.ToList();
                ViewBag.Fornecedores = this._database.Fornecedores.ToList();
                return View("../Gestao/Novoproduto");
            }
            
        }
    }
}