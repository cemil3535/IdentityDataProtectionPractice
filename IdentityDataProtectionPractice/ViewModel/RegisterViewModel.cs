using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtectionPractice.ViewModel
{
    public class RegisterViewModel
    {

        [Required]

        public string Email { get; set; }

        [Required]

        public string Password { get; set; }
    }
}
}
