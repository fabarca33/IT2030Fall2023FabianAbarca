using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace FabianMusic.Models
{
    public class Album
    {
        public Album() => Artists = new HashSet<Artist>();

        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        [MaxLength(200)]
        public string AlbumTitle { get; set; } = string.Empty;

        [Range(0.0, 1000000.0, ErrorMessage = "Price must be 1 or more.")]
        public double Price { get; set; }

        
        public ICollection<Album> Artists { get; set; }
    }
}