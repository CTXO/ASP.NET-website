using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set;}

        public DbSet<Produto> Produtos {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=rodolfo;Database=Cursomvc;Username=postgres;Password=ramses08.");
        }
    }
}