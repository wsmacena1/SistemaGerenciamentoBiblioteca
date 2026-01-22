using Biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Infrastructure
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) : base(options) { }
        public DbSet<Livro> Livros => Set<Livro>();
        public DbSet<Emprestimo> Emprestimos => Set<Emprestimo>();
    }
}
