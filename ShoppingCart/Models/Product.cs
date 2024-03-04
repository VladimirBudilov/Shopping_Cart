using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    [Table("products")]
    public class Product
    {
        [Required]
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }
        [Column("slug")]
        public string Slug { get; set; }
        [Required(ErrorMessage = "Please enter a product description")]
        [StringLength(255)]
        [Column("description")]
        public string Description { get; set; }
        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter a valid price")]
        [Column(name: "price", TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Column("image")]
        public string Image { get; set; }
        [Column("category_id")]
        public long CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
