
namespace FabianMusic.Models.ViewModels
{
    public class ArtistListViewModel
    {
        public IEnumerable<Album> Artists { get; set; } = new List<Album>();
        public ArtistGridData CurrentRoute {  get; set; } = new ArtistGridData();
        public int TotalPages { get; set; }
    }
}
