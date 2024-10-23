using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtectionPractice.ViewModel
{
    public class RegisterViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }
    }
}
}
