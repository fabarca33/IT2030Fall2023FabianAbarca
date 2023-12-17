using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using FabianMusic.Models;

namespace FabianMusic.Models.ViewModels
{
    public class ArtistGridData : GridData
    {
        public ArtistGridData() => SortField = nameof(Album.ArtistName);

        [JsonIgnore]
        public bool IsSortByName => SortField.EqualsNoCase(nameof(Album.ArtistName));
    }
}
