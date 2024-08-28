using Api.Dto.Vinculo;
using Api.Models;

namespace Api.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}