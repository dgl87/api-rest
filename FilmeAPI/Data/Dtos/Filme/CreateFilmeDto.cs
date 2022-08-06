using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Data.Dtos.Filme
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve estar entre 1 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
