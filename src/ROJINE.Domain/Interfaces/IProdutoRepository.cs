using ROJINE.Domain.Entities;

namespace ROJINE.Domain.Interfaces;

public interface IProdutoRepository
{
    Task<Produto> CreateAsync(Produto produto);
} 