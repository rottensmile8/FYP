using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    /*
     * Product Model Class
     * 
     * Demonstrates: Data Annotations for Validation
     * - Required: Ensures field is not empty
     * - StringLength: Validates minimum and maximum length
     * - Range: Validates numeric range
     * - Url: Validates URL format
     */
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Product name must be between 2 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 1_000_000, ErrorMessage = "Price must be between 1 and 1,000,000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, 10_000, ErrorMessage = "Quantity must be between 0 and 10,000")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(50, ErrorMessage = "Category cannot exceed 50 characters")]
        public string Category { get; set; } = string.Empty;

        [Url(ErrorMessage = "Invalid URL format")]
        public string? ImageUrl { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
