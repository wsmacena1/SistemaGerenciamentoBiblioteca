using Biblioteca.Application.Services;
using Microsoft.AspNetCore.Mvc;
using static Biblioteca.Application.DTOs.Emprestimo.EmprestimoDto;

namespace Biblioteca.Api.Controllers
{
    [ApiController]
    [Route("api/emprestimos")]
    public class EmprestimosController : Controller
    {
        private readonly EmprestimoService _service;
        public EmprestimosController(EmprestimoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CriarEmprestimoDto dto)
        {
            await _service.RealizarEmprestimoAsync(dto.LivroId);
            return Ok("Empréstimo registrado");
        }
    }
}
