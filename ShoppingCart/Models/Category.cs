using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    [Table("categories")]
    public class  Category
    {
        [Required]
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter a category name")]
        [StringLength(100)]
        [Column("name")]
        public string Name { get; set; }
        [Column("slug")]
        public string Slug { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}