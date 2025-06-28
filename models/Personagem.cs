using System.ComponentModel.DataAnnotations;

namespace projetoDBZ.models
{
    public class Personagem
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome e um campo obrigatorio!")]
        [MaxLength(50, ErrorMessage ="nome precisa ter 50 caracters")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "tipo e um campo obrigatorio!")]
        [MaxLength(50, ErrorMessage ="tipo precisa ter 50 caracters")]
        public string Tipo { get; set; }
    }
}