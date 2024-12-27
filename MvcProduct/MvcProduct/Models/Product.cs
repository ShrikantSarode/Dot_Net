using System.ComponentModel.DataAnnotations;

namespace MvcProduct.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = null!;

        [Required]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string? Category { get; set; }
    }
}
