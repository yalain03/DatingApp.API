using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength=4, ErrorMessage="You must enter a passwordbetween 4 and 32 characters")]
        public string Password { get; set; }
    }
}