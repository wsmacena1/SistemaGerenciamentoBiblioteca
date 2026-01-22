using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infrastructure.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private BibliotecaDbContext _context;

        public EmprestimoRepository(BibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Emprestimo emprestimo)
        {
            if (emprestimo != null)
            {
                _context.Emprestimos.Add(emprestimo);
                await _context.SaveChangesAsync();
            }
        }
    }
}
