using api_filmes_senai.Domains;
using api_filmes_senai.Interface;
using api_filmes_senai.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepository _generoRepository;
        public GeneroController(IGeneroRepository generoRepository)
        {
            _generoRepository = generoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Genero> lista = _generoRepository.Listar();

                return StatusCode(200, lista);

            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }

        }

        [HttpPost]

        public IActionResult Post(Genero novoGenero)
        {
            try
            {
                _generoRepository.Cadastrar(novoGenero);

                return Created();

            }
            catch (Exception e) 
            { 
                return BadRequest(e.Message);
            }
        }

    }
}
