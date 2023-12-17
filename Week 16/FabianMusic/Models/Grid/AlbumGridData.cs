using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using FabianMusic.Models;

namespace FabianMusic.Models.ViewModels
{
    public class AlbumGridData : GridData
    {
        public AlbumGridData() => SortField = nameof(Album.AlbumTitle);

        [JsonIgnore]
        public bool IsSortByPrice => SortField.EqualsNoCase(nameof(Album.Price));
    }
}
