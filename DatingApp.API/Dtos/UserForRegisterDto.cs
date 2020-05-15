using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4,
                ErrorMessage = "Password should contain min of 4 and max" +
                 " of 8 characters")]
        public string Password { get; set; }
    }
}
