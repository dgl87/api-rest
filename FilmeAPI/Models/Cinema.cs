﻿using System.ComponentModel.DataAnnotations;

namespace FilmeAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de Nome é obrigatório")]
        public string Nome { get; set; }
    }
}