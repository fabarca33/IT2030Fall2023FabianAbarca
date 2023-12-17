
namespace FabianMusic.Models.ViewModels
{
    public class AlbumListViewModel
    {
        public IEnumerable<Album> Albums { get; set; } = new List<Album>();
        public AlbumGridData CurrentRoute {  get; set; } = new AlbumGridData();
        public int TotalPages { get; set; }
    }
}
