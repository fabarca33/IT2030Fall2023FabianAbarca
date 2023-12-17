using System.ComponentModel.DataAnnotations;
namespace FabianMusic.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Please enter your first name.")]
        [StringLength (30, ErrorMessage = "First name must be 30 characters or less")]
        [RegularExpression ("^[A-Za-z]+$", ErrorMessage = "First name cannot contain special characters or numbers")]
        public string? FirstName { get; set; }

        
        [Required(ErrorMessage = "Please enter your last name.")]
        [StringLength(30, ErrorMessage = "Last name must be 30 characters or less")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Last name cannot contain special characters or numbers")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must have exactly 10 digits")]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Phone number must contain only numbers")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress (ErrorMessage = "Enter a valid email address.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Tell us how we can help")]
        public string? Message { get; set; }

        [Key]
        public int ContactId { get; set; }
    }
}