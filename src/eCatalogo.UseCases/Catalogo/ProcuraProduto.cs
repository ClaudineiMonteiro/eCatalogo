using eCatalogo.Core.Models;
using eCatalogo.UseCases.Interfaces.Repositories;

namespace eCatalogo.UseCases.Catalogo;

public class ProcuraProduto : IProcuraProduto
{
    private readonly IProdutoRepository _produtoRepository;

    public ProcuraProduto(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public IEnumerable<Produto> Execute(string filter = null)
    {
        return _produtoRepository.GetProdutos(filter);
    }
}
