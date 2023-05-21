using System.ComponentModel.DataAnnotations;

namespace ChatterApi.Dtos
{
    public class UserDto
    {
        [Required]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Ime mora sadržavati minimalno {2}, a maksimalno {1} karaktera")]
        public string Name { get; set; }
    }
}
