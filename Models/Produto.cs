using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Produto
    {
        [Key]
        public int Id {get; set;}

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Descricao {get; set;}

        public int Quantidade {get; set;}
        public int CategoriaId {get; set;}
        public Categoria Categoria {get; set;}
    }
}