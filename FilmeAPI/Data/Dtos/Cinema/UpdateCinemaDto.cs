using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos.Cinema
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatírio")]
        public string Nome { get; set; }
    }
}