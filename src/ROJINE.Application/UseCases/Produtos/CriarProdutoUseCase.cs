using ROJINE.Application.DTOs;
using ROJINE.Domain.Entities;
using ROJINE.Domain.Interfaces;

namespace ROJINE.Application.UseCases.Produtos;

public class CriarProdutoUseCase
{
    private readonly IProdutoRepository _produtoRepository;

    public CriarProdutoUseCase(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<Produto> ExecuteAsync(ProdutoDTO dto)
    {
        var produto = new Produto
        {
            Nome = dto.Nome,
            Preco = dto.Preco,
            Estoque = dto.Estoque,
            DataCadastro = DateTime.Now
        };

        return await _produtoRepository.CreateAsync(produto);
    }
} 