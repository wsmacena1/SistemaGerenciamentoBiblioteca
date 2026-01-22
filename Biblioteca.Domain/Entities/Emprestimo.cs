using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Entities
{
    public class Emprestimo
    {
        public Guid Id { get; private set; }
        public Guid LivroId { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        private Emprestimo() { }
        public Emprestimo(Guid livroId, DateTime dataEmprestimo)
        {
            LivroId = livroId;
            DataEmprestimo = dataEmprestimo;
        }
    }
}
