namespace CursoMVC.Models
{
    public class Produto
    {
        public int id {get; set;}
        public string Descricao {get; set;}

        public int Quantidade {get; set;}
        public int CategoriaID {get; set;}
        public Categoria Categoria {get; set;}
    }
}