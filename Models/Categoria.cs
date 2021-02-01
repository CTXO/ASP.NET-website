using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria{

        [Key]
        public int Id {get; set;}

        public string Descricao  { get; set; }

        List<Produto> Produtos {get; set;}

    }
}