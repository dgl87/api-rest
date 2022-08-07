using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos.Cinema
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
}