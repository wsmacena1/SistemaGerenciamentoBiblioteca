using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using Biblioteca.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.Services
{
    public class EmprestimoService
    {
        private readonly ILivroRepository _livroRepository;
        private readonly IEmprestimoRepository _emprestimoRepository;
        private readonly BibliotecaDbContext _context;
        public EmprestimoService(ILivroRepository livroRepository,
        IEmprestimoRepository emprestimoRepository,
        BibliotecaDbContext context)
        {
            _livroRepository = livroRepository;
            _emprestimoRepository = emprestimoRepository;
            _context = context;
        }

        public async Task RealizarEmprestimoAsync(Guid livroId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync(); //Caso ocorra erro, cai no tratamento e faz rolllback
            try
            {
                var livro = await _livroRepository.ObterPorIdAsync(livroId);
                if (livro == null)
                {
                    throw new Exception("Livro não encontrado.");
                }
                livro.CadastrarEmprestimo();
                var emprestimo = new Emprestimo(livroId, DateTime.Now);

                await _livroRepository.AtualizarAsync(livro);
                await _emprestimoRepository.AdicionarAsync(emprestimo);
                await transaction.CommitAsync();
            }
            catch
            {
                await transaction.RollbackAsync(); 
                throw;
            }
        }
    }
}
