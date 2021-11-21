using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Supermarket_system_with_ASP.NET_Core.Data;
using Supermarket_system_with_ASP.NET_Core.DTO;

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
            var categorias = this._database.Categorias.ToList();
            return View(categorias);
        }

        public IActionResult NovaCategoria(){
            return View();
        }

        public IActionResult EditarCategoria(int Id){ //Recebendo o ID cateogria por parametro
            var categoria = this._database.Categorias.First(categoria => categoria.Id == Id); // Buscando a informação da categoria no Banco de dados
            CategoriaDTO categoriaView = new CategoriaDTO(); //Convertendo o objeto Categoria em um objeto CategoriaDTO (Que é o tipo de objeto que o formulario (view) lida)
            categoriaView.Id = categoria.Id;
            categoriaView.Nome = categoria.Nome;
            return View(categoriaView);//Passando para a view o objeto resultando do banco de dados.
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