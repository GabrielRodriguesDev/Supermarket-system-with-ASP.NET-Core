using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Supermarket_system_with_ASP.NET_Core.Models;

namespace Supermarket_system_with_ASP.NET_Core.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias {get;set;}

        public DbSet<Fornecedor> Fornecedores {get;set;}

        public DbSet<Produto> Produtos {get;set;}

        public DbSet<Promocao> Promocoes {get;set;}
        public DbSet<Estoque> Estoque {get;set;}

        public DbSet<Saida> Saidas {get;set;}

        public DbSet<Venda> Vendas {get;set;}
    }
}
