using System.Text.Json.Serialization;

namespace Api.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public AutorModel Autor { get; set; }
    }
}