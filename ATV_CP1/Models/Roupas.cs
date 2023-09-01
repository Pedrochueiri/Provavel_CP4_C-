using System.ComponentModel.DataAnnotations;

namespace ATV_CP1.Models
{
    public class Roupas
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Cor { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        public bool NoEstoque { get; set; }
    }
}
