using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.DTO;
using Supermarket_system_with_ASP.NET_Core.Data;
using Supermarket_system_with_ASP.NET_Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

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
                Console.WriteLine(CultureInfo.InvariantCulture.NumberFormat);   
                produto.Nome = produtoTemporario.Nome;
                produto.Categoria = this._database.Categorias.First(categoria => categoria.Id == produtoTemporario.CategoriaID);
                produto.Fornecedor = this._database.Fornecedores.First(fornecedor => fornecedor.Id == produtoTemporario.FornecedorID);
                produto.PrecoDeCusto = float.Parse(produtoTemporario.PrecoDeCustoString, CultureInfo.InvariantCulture.NumberFormat);
                produto.PrecoDeVenda = float.Parse(produtoTemporario.PrecoDeVendaString, CultureInfo.InvariantCulture.NumberFormat); 
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

        [HttpPost]
        public IActionResult Atualizar (ProdutoDTO produtoTemporario){
            if(ModelState.IsValid){
                var produto = this._database.Produtos.First(produto => produto.Id == produtoTemporario.Id);
                produto.Nome = produtoTemporario.Nome;
                produto.Categoria = this._database.Categorias.First(categoria => categoria.Id == produtoTemporario.CategoriaID);
                produto.Fornecedor = this._database.Fornecedores.First(fornecedor => fornecedor.Id == produtoTemporario.FornecedorID);
                produto.PrecoDeCusto = float.Parse(produtoTemporario.PrecoDeCustoString, CultureInfo.InvariantCulture.NumberFormat);
                produto.PrecoDeVenda = float.Parse(produtoTemporario.PrecoDeVendaString, CultureInfo.InvariantCulture.NumberFormat); 
                produto.Medicao = produtoTemporario.Medicao;
                this._database.SaveChanges();
                return RedirectToAction("Produtos","Gestao");
            } else {
                ViewBag.Categorias = this._database.Categorias.ToList();
                ViewBag.Fornecedores = this._database.Fornecedores.ToList();
                return View("../Gestao/EditarProduto");
            }
        }

        [HttpPost]
        public IActionResult Deletar (int Id){
            if(Id > 0) {
                var produto = this._database.Produtos.First(produto => produto.Id == Id);
                produto.Status = false;
                this._database.SaveChanges();
            } 
                return RedirectToAction("Produtos","Gestao");
        }

        [HttpPost]
        public IActionResult Produto (int id){
            if(id > 0) {
                var produto = this._database.Produtos.Where(produto => produto.Status == true).Include(produto => produto.Categoria).Include(produto => produto.Fornecedor).FirstOrDefault(produto => produto.Id == id);
                if(produto != null) {
                    var estoque = this._database.Estoque.FirstOrDefault(estoque => estoque.Produto.Id == produto.Id);
                    
                    if(estoque != null) {

                        var promocao = this._database.Promocoes.FirstOrDefault(promocao => promocao.Produto.Id == produto.Id && promocao.Status == true);
                        if(promocao != null){
                            produto.PrecoDeVenda -=(produto.PrecoDeVenda * promocao.Porcentagem/100); 
                        }
                        Response.StatusCode = 200;  
                        return Json(produto);
                    } else {
                        produto = null;
                        Response.StatusCode = 404;
                        return Json(produto);
                    } 
                    
                
                } else {
                    Response.StatusCode = 404;
                    return Json(null);
                }
                
            }
            Response.StatusCode = 404;
            return Json(null);
            
        }
    }
}