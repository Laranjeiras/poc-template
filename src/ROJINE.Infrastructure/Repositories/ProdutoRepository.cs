using Microsoft.EntityFrameworkCore;
using ROJINE.Domain.Entities;
using ROJINE.Domain.Interfaces;
using ROJINE.Infrastructure.Context;

namespace ROJINE.Infrastructure.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly ApplicationDbContext _context;

    public ProdutoRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Produto> CreateAsync(Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();
        return produto;
    }
} 