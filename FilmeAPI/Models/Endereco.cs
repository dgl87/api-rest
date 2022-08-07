using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public Cinema Cinema { get; set; }
    }
}