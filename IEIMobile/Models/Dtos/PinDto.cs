using System.ComponentModel.DataAnnotations;

namespace IEIMobile.Models.Dtos
{
    public class PinDto
    {
        [Required]
        [MinLength(12)]
        [MaxLength(15)]
        public string Pin { get; set; }
    }
}