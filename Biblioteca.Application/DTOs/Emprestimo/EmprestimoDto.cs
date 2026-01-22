using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.DTOs.Emprestimo
{
    public class EmprestimoDto
    {
        public record CriarEmprestimoDto(Guid LivroId);

        public record EmprestimoPeriodoDto(Guid Id,Guid LivroId,DateTime DataEmprestimo);

    }
}
