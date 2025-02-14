using Microsoft.AspNetCore.Mvc;
using ROJINE.Application.DTOs;
using ROJINE.Application.UseCases.Produtos;

namespace ROJINE.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly CriarProdutoUseCase _criarProdutoUseCase;

    public ProdutosController(CriarProdutoUseCase criarProdutoUseCase)
    {
        _criarProdutoUseCase = criarProdutoUseCase;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProdutoDTO produtoDTO)
    {
        var produto = await _criarProdutoUseCase.ExecuteAsync(produtoDTO);
        return CreatedAtAction(nameof(Create), new { id = produto.Id }, produto);
    }
} 