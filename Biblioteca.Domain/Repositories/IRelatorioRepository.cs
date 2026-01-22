using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Application.DTOs;

namespace Biblioteca.Domain.Repositories
{
    public interface IRelatorioRepository
    {
        Task<IEnumerable<LivroEstoqueDto>> LivrosComBaixoEstoque();
    }
}
