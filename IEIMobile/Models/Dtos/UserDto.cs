using System.ComponentModel.DataAnnotations;

namespace IEIMobile.Models.Dtos
{
    public class UserDto
    {
        [Required]
        public string Pin { get; set; }
        [Required]
        public string Password { get; set; }
    }
}