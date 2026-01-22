using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Repositories
{
    public interface ILivroRepository
    {
        Task<Entities.Livro> ObterPorIdAsync(Guid id);
        Task AtualizarAsync(Livro livro);
        Task AdicionarAsync(Livro livro);

    }
}
