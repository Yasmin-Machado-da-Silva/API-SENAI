using api_filmes_senai.Domains;
using api_filmes_senai.Interface;
using api_filmes_senai.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_filmes_senai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]

    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;        
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<Filmes> listaDeFilmes = _filmeRepository.Listar();
                return Ok(listaDeFilmes);
            }
            catch (Exception e) 
            {
                return BadRequest(e.Message);
            }
        }
    }
}
