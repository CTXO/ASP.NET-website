using System;
using System.Collections.Generic;

namespace CursoMVC.Models
{
    public class Categoria{
        public int Id {get; set;}

        public string Descricao  { get; set; }

        List<Produto> Produtos {get; set;}

    }
}