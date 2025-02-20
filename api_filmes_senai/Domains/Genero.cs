using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai.Domains
{
    public class Genero
    {

        [Key]

        public Guid IdGenero { get; set; }

        [Column(TypeName = "VARACHAR (30)")]
        [Required(ErrorMessage = "Nome do Gênero é obrigarório" )]
        public string? Nome{ get; set; }
    }
}
