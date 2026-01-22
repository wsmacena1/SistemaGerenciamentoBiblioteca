using Biblioteca.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using static Biblioteca.Application.DTOs.Livro.LivroDto;

namespace Biblioteca.Infrastructure.Repositories;

public class RelatorioRepository :IRelatorioRepository
{
    private readonly BibliotecaDbContext _context;

    public RelatorioRepository(BibliotecaDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<LivroEstoqueDto>> LivrosComBaixoEstoque()
    {
        //return await _context.Livros
    }
}