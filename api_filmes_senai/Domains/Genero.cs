using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Components;

namespace api_filmes_senai.Domains
{
    public class Genero
    {

        [Key]
        public Guid IdGenero { get; set; }

        [Column(TypeName = "VARCHAR (30)")]
        [Required(ErrorMessage = "Nome do Gênero é obrigarório" )]
        public string? Nome{ get; set; }
    }
}
