using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Application.DTOs.Livro
{
    public class LivroDto
    {
        public record CriarLivroDto(string Titulo, int Quantidade);

        public record LivroEstoqueDto(Guid Id, string Titulo, int Quantidade);
    }
}
