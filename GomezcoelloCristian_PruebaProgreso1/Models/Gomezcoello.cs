using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GomezcoelloCristian_PruebaProgreso1.Models
{
    public class Gomezcoello
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Range(0, 95)]
        public double Edad { get; set; }
        [Required]
        public int Hermanos { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(200)]
        public string Direccion { get; set; }
        [NotNull]
        public Boolean Quiteno { get; set; }
        public DateTime? DireccionDate { get; set; }

        public Celular? Celular { get; set; }
        [ForeignKey("Celular")]
        public int IdCelular { get; set; }


    }
}
