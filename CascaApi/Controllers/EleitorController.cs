using CascaApi.Repository;
using CascaApi.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CascaApi.Models;

namespace CascaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EleitorController : ControllerBase
    {
        private readonly IEleitorRepository _repository;

        public EleitorController(IEleitorRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            var eleitores = _repository.Listar();
            return Ok(eleitores);
        }

        [HttpPost]
        public IActionResult CadastroEleitores(Eleitor eleitor)
        {
            var sucesso = _repository.Adicionar(eleitor);
            if (!sucesso)
            {
                return Conflict("Já existe um eleitor com o mesmo cpf.");

            }
            return Created("", eleitor);

        }
        
    }
}
