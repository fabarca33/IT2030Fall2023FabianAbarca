using System.ComponentModel.DataAnnotations;
namespace FabianMusic.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Tell us how we can help")]
        public string? Message { get; set; }
    }
}