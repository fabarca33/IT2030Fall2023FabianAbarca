namespace FabianMusic.Models
{
    public class ProductData
    {
        public static List<ProductModel> GetProducts()
        {
            List<ProductModel> products = new List<ProductModel>
            {
            new ProductModel {
                ProductId = 1,
                ProductName = "Led Zepelin I - Led Zepelin",
                ProductDescription = "60s Classic Rock",
                ProductImage = "/images/ledzeppelinI.jpg",
                ProductPrice = 34,
            },

            new ProductModel
            {
                ProductId = 2,
                ProductName = "Painkiller - Judas Priest",
                ProductDescription = "90s Heavy Metal",
                ProductImage = "/images/painkiller.jpg",
                ProductPrice = 19,
            },

            new ProductModel
            {
                ProductId = 3,
                ProductName = "Purple Rain - Prince",
                ProductDescription = "80s Classic Rock",
                ProductImage = "/images/purplerain.png",
                ProductPrice = 18,
            },

            new ProductModel
            {
                ProductId = 4,
                ProductName = "Machine Head - Deep Purple",
                ProductDescription = "70s Classic Rock",
                ProductImage = "/images/machinehead.jpg",
                ProductPrice = 29,
            },

            new ProductModel
            {
                ProductId = 5,
                ProductName = "With the Beatles - The Beatles",
                ProductDescription = "60s Classic",
                ProductImage = "/images/Withthebeatles.jpg",
                ProductPrice = 30,
            },

            new ProductModel
            {
                ProductId = 6,
                ProductName = "Ride the Lightning - Metallica",
                ProductDescription = "80s Heavy Metal",
                ProductImage = "/images/ridethelightning.jpg",
                ProductPrice = 21,
            }
            };

            return products;
        }
        public static ProductModel GetProduct(int id)
        {
            List<ProductModel> products = ProductData.GetProducts();
            foreach (ProductModel product in products) 
            {
                if (product.ProductId == id)
                {
                    return product;
                }
            }
            return new ProductModel();
        }
    }
}