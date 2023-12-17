using FabianMusic.Data;
using FabianMusic.Models;
using FabianMusic.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;

namespace FabianMusic.Controllers
{
    public class AlbumController : Controller
    {
        Repository<Album> data {  get; set; }
        public AlbumController(FabianMusicContext ctx) => data = new Repository<Album>(ctx);

        public RedirectToActionResult Index() => RedirectToAction("List");

        public ViewResult List(AlbumGridData values)
        {
            var options = new QueryOptions<Album>
            {
                Includes = "Artist",
                OrderByDirection = values.SortDirection,
                PageNumber = values.PageNumber,
                PageSize = values.PageSize,
                
            };
            if (values.IsSortByPrice)
                options.OrderBy = b => b.Price;
            else
                options.OrderBy = b => b.AlbumTitle;

            var vm = new AlbumListViewModel
            {
                Albums = data.List(options),
                CurrentRoute = values,
                TotalPages = values.GetTotalPages(data.Count)
            };
            return View(vm);
        }

        public ViewResult Details(int id)
        {
            var artist = data.Get(new QueryOptions<Album>
            {
                Where = b => b.AlbumId == id,
                Includes = "Artists"
            }) ?? new Album();
            return View(album);
        }
    }
}