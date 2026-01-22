using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Repositories
{
    public interface IEmprestimoRepository
    {
        Task AdicionarAsync(Emprestimo emprestimo);
    }
}
