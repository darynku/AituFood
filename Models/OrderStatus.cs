using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AituFood.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        public int Id { get; set; }
        [Required, MaxLength(69)]
        public string? StatusName { get; set; }
        [Required]
        public int StatusId { get; set; }
        

    }
}
