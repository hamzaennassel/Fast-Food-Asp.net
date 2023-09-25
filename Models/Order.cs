using System.ComponentModel.DataAnnotations;

namespace Plat1.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long Tel { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        public string NomPlat { get; set; }
    }
}
