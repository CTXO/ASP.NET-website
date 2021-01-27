using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,5432;Database=Cursomvc;Integrated Security=True;");
            
        }
    }
}