using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var categorias = this._database.Categorias.Where(categoria => categoria.Status == true).ToList();
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
            var fornecedores = this._database.Fornecedores.Where(fornecedores => fornecedores.Status == true).ToList();
            return View(fornecedores);
        }

        public IActionResult NovoFornecedor(){
            return View();
        }

        public IActionResult EditarFornecedor(int id) {
                var fornecedor = this._database.Fornecedores.First(fornecedor => fornecedor.Id == id);
                FornecedorDTO fornecedorView = new FornecedorDTO();
                fornecedorView.Id = fornecedor.Id;
                fornecedorView.Nome = fornecedor.Nome;
                fornecedorView.Email = fornecedor.Email;
                fornecedorView.Telefone = fornecedor.Telefone;
                return View(fornecedorView);
        }

        public IActionResult Produtos(){ // Include() Inclui as entidades relacionadas
            var produtos = this._database.Produtos
            .Where(produto => produto.Status == true)
            .Include(produto => produto.Categoria)
            .Include(produto => produto.Fornecedor)
            .ToList();

            return View(produtos);
        }

        public IActionResult NovoProduto(){
            ViewBag.Categorias = this._database.Categorias.Where(categoria => categoria.Status == true).ToList();
            ViewBag.Fornecedores = this._database.Fornecedores.Where(fornecedor => fornecedor.Status == true).ToList();

            return View();
        }

        public IActionResult EditarProduto(int id){

            ViewBag.Categorias = this._database.Categorias.ToList(); // carregando a informaçõe da caixa de seleção de categoria
            ViewBag.Fornecedores = this._database.Fornecedores.ToList(); // carregando a informaçõe da caixa de seleção de fornecedor
            var produto =this._database.Produtos.Include(produto => produto.Categoria).Include(produto => produto.Fornecedor).First(produto => produto.Id == id);

            ProdutoDTO produtoView = new ProdutoDTO();
            produtoView.Nome = produto.Nome;
            produtoView.CategoriaID = produto.Categoria.Id;
            produtoView.FornecedorID = produto.Fornecedor.Id;
            produtoView.Nome = produto.Nome;
            produtoView.PrecoDeCustoString = string.Format("{0:N2}",produto.PrecoDeCusto);
            produtoView.PrecoDeVendaString = string.Format("{0:N2}",produto.PrecoDeVenda);
            produtoView.Medicao = produto.Medicao;
            return View(produtoView);
        }

        public IActionResult Promocoes() {
            var promocoes = this._database.Promocoes.Where(promocao => promocao.Status == true).Include(promocao => promocao.Produto).ToList();
            return View(promocoes);
        }

        public IActionResult NovaPromocao() {
            ViewBag.Produtos = this._database.Produtos.Where(produto => produto.Status == true).ToList();
            
            return View();
        }

        public IActionResult EditarPromocao(int Id){
            ViewBag.Produtos = this._database.Produtos.Where(produto => produto.Status == true).ToList();

            var promocao = this._database.Promocoes.Include(promocao => promocao.Produto).First(promocao => promocao.Id == Id);

            PromocaoDTO promocaoView  = new PromocaoDTO();
            promocaoView.Id = promocao.Id;
            promocaoView.Nome = promocao.Nome;
            promocaoView.ProdutoID = promocao.Produto.Id; 
            promocaoView.Porcentagem = promocao.Porcentagem;
            return View(promocaoView);
        }

        public IActionResult Estoque() {
            var listaEstoque =this._database.Estoque.Include(estoque => estoque.Produto).Where(estoque => estoque.Quantidade > 0).ToList();
            return View(listaEstoque);
        }

        public IActionResult NovoEstoque(){
            ViewBag.Produtos = this._database.Produtos.Where(produto => produto.Status == true).ToList();
            return View();
        }

        public IActionResult EditarEstoque() {
            return Content("");
        }

        public IActionResult Vendas() {
            var listaVendas = this._database.Vendas.ToList();
            return View(listaVendas);
        }

        [HttpPost]
        public IActionResult RelatorioDeVendas(){
            return Ok(this._database.Vendas.ToList());
        }
    }

}