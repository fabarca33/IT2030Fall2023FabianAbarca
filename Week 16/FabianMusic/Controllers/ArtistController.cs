using FabianMusic.Models;
using FabianMusic.Models.Data;
using FabianMusic.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;

namespace FabianMusic.Controllers
{
    public class ArtistController : Controller
    {
        private Repository<Album> data {  get; set; }
        public ArtistController(FabianMusicContext ctx) => data = new Repository<Album>(ctx);

        public IActionResult Index() => RedirectToAction("List");

        public ViewResult List(ArtistGridData values)
        {
            var options = new QueryOptions<Album>
            {
                Includes = "Albums",
                PageNumber = values.PageNumber,
                PageSize = values.PageSize,
                OrderByDirection = values.SortDirection,
            };
            if (values.IsSortByName)
                options.OrderBy = a => a.Name;

            var vm = new ArtistListViewModel
            {
                Artists = data.List(options),
                CurrentRoute = values,
                TotalPages = values.GetTotalPages(data.Count)
            };
            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var artist = data.Get(new QueryOptions<Album>
            {
                Where = a => a.ArtistId == id,
                Includes = "Albums"
            }) ?? new Artist();
            return View(artist);
        }
    }
}