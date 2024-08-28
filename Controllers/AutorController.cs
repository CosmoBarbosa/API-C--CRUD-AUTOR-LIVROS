using Api.Dto.Autor;
using Api.Models;
using Api.Services.Autor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {

        private readonly IAutorInterface _autorInterface;

        public AutorController(IAutorInterface autorIntercface) {
            _autorInterface = autorIntercface;
        }

        [HttpGet("ListarAutores")]

        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> ListarAutores()
        {
            var autores = await _autorInterface.ListarAutores();
            return Ok(autores);
        }

        [HttpGet("BuscaAutorPorId/{idAutor}")]

        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorId(int idAutor)
        {
            var autores = await _autorInterface.BuscarAutorPorId(idAutor);
            return Ok(autores);
        }
        
        [HttpGet("BuscaAutorPorIdLivro/{idLivro}")]

        public async Task<ActionResult<ResponseModel<AutorModel>>> BuscarAutorPorIdLivro(int idLivro)
        {
            var autores = await _autorInterface.BuscarAutorPorIdLivro(idLivro);
            return Ok(autores);
        }

        [HttpPost("CriarAutor")]
        public async Task<ActionResult<ResponseModel<AutorModel>>> CriarAutor(AutorCriacaoDto autorCriacaoDto)
        {
            var autores = await _autorInterface.CriarAutor(autorCriacaoDto);
            return Ok(autores);
        }

        [HttpPut("EditarAutor")]
        public async Task<ActionResult<ResponseModel<List<AutorModel>>>> EditarAutor(AutorEdicaoDto autorEdicaoDto)
        {
            var autores = await _autorInterface.EditarAutor(autorEdicaoDto);
            return Ok(autores);
        }

        [HttpDelete("ExcluirAutorPorId/{idAutor}")]

        public async Task<ActionResult<ResponseModel<AutorModel>>> ExcluirAutor(int idAutor)
        {
            var autores = await _autorInterface.ExcluirAutor(idAutor);
            return Ok(autores);
        }


    }
}
