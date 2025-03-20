using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace filmesApi.models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Campo obrigatório!")]
        [MaxLength(50, ErrorMessage ="Maximo 50 caracteres!")]
        public string Genero { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage ="Duração entre 70 e 600 minutos!")]
        public int Duracao { get; set; }
    }
}