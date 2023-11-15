using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabianMusic.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter your the product's name.")]
        public string ProductName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please write a description.")]
        public string ProductDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a picture.")]
        public string ProductImage { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductPrice { get; set; }
    }
}