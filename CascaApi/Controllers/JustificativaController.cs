using CascaApi.Models;
using CascaApi.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CascaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JustificativaController : ControllerBase
    {
        private readonly IJustificativaRepository _repository;

        public JustificativaController(IJustificativaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var justificativas = _repository.Listar();
            return Ok(justificativas);
        }
        [HttpPost]
        public IActionResult CadastroJustificativas(Justificativa justificativa)
        {
            _repository.Adicionar(justificativa);
            return Created("", justificativa);
            }
    }
}
