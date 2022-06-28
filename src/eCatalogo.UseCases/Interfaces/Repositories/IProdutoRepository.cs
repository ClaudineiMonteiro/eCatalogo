using eCatalogo.Core.Models;

namespace eCatalogo.UseCases.Interfaces.Repositories;

public interface IProdutoRepository
{
    Produto GetProduto(int id);
    IEnumerable<Produto> GetProdutos(string filter = null);
}
