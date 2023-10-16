namespace FabianMusic.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductImage { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
    }
}