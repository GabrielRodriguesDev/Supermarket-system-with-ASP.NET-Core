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
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Categoria> Categorias {get;set;}

        DbSet<Fornecedor> Fornecedores {get;set;}

        DbSet<Produto> Produtos {get;set;}

        DbSet<Promocao> Promocoes {get;set;}
        DbSet<Estoque> Estoques {get;set;}

        DbSet<Saida> Saidas {get;set;}

        DbSet<Venda> Vendas {get;set;}
    }
}
