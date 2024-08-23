using GCook.Models;

namespace GCook.ViewModels;

public class HomeVm
{
    public List<Categoria> Categorias { get; set; }
    public List<Receita> Receitas { get; set; }
}
