using Api.Dto.Vinculo;
using Api.Models;

namespace Api.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
