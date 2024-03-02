using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AituFood.Models
{
    [Table("Cart")]
    public class Cart
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }

        public ICollection<CartDetail> CartDetails { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
