using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GomezcoelloCristian_PruebaProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Required]
        [Range(2000,2025)]
        public int Ano { get; set; }
        [NotNull]
        [Display(Name = "Precio")]
        public int Precio { get; set; }
    }
}
 