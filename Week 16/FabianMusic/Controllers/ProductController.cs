using FabianMusic.Models;
using Microsoft.AspNetCore.Mvc;

namespace FabianMusic.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ListProducts()
        {
            List<ProductModel> products = ProductData.GetProducts();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            ProductModel product = ProductData.GetProduct(id);
            return View(product);
        }
    }
}
