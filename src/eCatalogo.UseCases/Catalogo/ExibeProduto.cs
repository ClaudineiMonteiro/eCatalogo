using eCatalogo.Core.Models;
using eCatalogo.UseCases.Interfaces.Repositories;

namespace eCatalogo.UseCases.Catalogo;

public class ExibeProduto : IExibeProduto
{
    private readonly IProdutoRepository _produtoRepository;

    public ExibeProduto(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public Produto Execute(int id)
    {
        return _produtoRepository.GetProduto(id);
    }
}
