using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AituFood.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]

        public string? ProductName { get; set; }

        [Required]
        [MaxLength(50)]
        public Category? Category { get; set; }
        public List<OrderDetail>? OrderDetail { get; set; }
        public List<CartDetail>? CartDetail { get; set; }
        public string? Image { get; set; }

        [Required]
        [MaxLength(50)]
        public double Price { get; set; }
        public string? CompanyName { get; set; }
        public string? CategoryName { get; set; }

    }
}
