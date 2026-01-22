using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using static Biblioteca.Application.DTOs.Livro.LivroDto;

namespace Biblioteca.Api.Controllers;

[ApiController]
[Route("api/livros")]
public class LivrosController : ControllerBase
{
    private readonly ILivroRepository _repository;

    public LivrosController(ILivroRepository repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Post(CriarLivroDto dto)
    {
        var livro = new Livro(dto.Titulo, dto.Quantidade);
        await _repository.AdicionarAsync(livro);

        return Ok(livro.Id);
    }
}