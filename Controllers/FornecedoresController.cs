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
    public class FornecedoresController: Controller
    {
        private readonly ApplicationDbContext _database;
        public FornecedoresController(ApplicationDbContext databse)
        {
            this._database = databse;
        }
        [HttpPost]
        public IActionResult Salvar(FornecedorDTO fornecedorTemporario){
            if(ModelState.IsValid) {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.Nome = fornecedorTemporario.Nome;
                fornecedor.Email = fornecedorTemporario.Email;
                fornecedor.Telefone = fornecedorTemporario.Telefone;
                fornecedor.Status = true;

                this._database.Fornecedores.Add(fornecedor);
                this._database.SaveChanges();
                return RedirectToAction("Fornecedores","Gestao");
            }else{
                return View("../Gestao/NovoFornecedor");
            }
        }
    }
}