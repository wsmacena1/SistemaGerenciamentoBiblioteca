using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Domain.Entities
{
    public class Livro
    {
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public int Saldo { get; private set; }


        private Livro() { }

        public Livro(string titulo, int saldo)
        {
            if(saldo <= 0)
            {
                throw new ArgumentException("Quantidade deve ser maior que zero.");
            }

            Id = Guid.NewGuid();
            Titulo = titulo;
            Saldo = saldo;
        }

        public void CadastrarEmprestimo()
        {
            if(Saldo <= 0)
            {
                throw new InvalidOperationException("Não há exemplares disponíveis para empréstimo.");
            }
            Saldo--;
        }
    }
}
