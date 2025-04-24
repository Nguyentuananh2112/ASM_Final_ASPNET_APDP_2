using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ASM_SIMS.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 60 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(100, ErrorMessage = "Full Name must be less than 100 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@&#$!%*?&])[A-Za-z\d@&#$!%*?&]{6,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one number, and one special character (@, &, #, $, !, %, *, ?).")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits")]
        public string Phone { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }
    }
}