using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infrastructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BibliotecaDbContext _context;

        public LivroRepository(BibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<Livro?> ObterPorIdAsync(Guid id)
        {
            return await _context.Livros.AsNoTracking().SingleOrDefaultAsync(l => l.Id == id);
        }

        public async Task AdicionarAsync(Livro livro)
        {
            if (livro != null)
            {
                _context.Set<Livro>().Add(livro);
            }
        }

        public async Task AtualizarAsync(Livro livro)
        {
            if (livro != null)
            {
                _context.Set<Livro>().Update(livro);
            }
        }

    }
}
