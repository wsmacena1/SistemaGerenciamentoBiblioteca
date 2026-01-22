using Biblioteca.Application.Services;
using Biblioteca.Domain.Repositories;
using Biblioteca.Infrastructure;
using Biblioteca.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BibliotecaDbContext>(options => options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=DEV;Integrated Security=False;User ID=sa;Password=inter#system;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"));

builder.Services.AddScoped<ILivroRepository, LivroRepository>();
builder.Services.AddScoped<IEmprestimoRepository, EmprestimoRepository>();
builder.Services.AddScoped<EmprestimoService>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
