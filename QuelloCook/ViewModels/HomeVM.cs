using QuelloCook.Models;

namespace QuelloCook.ViewModels;

    public class HomeVM
    {
        public List<Categoria> Categorias { get; set; }

        public List<Receita> Receitas { get; set; }
    }
