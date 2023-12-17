using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FabianMusic.Models
{
    public class Album
    {
        public Album() => Albums = new HashSet<Album>();

        public int ArtistId { get; set; }

        [Required(ErrorMessage = "Please enter artist name.")]
        [MaxLength(200)]
        public string ArtistName { get; set; } = string.Empty;

        public ICollection<Album> Albums { get; set; }
    }
}