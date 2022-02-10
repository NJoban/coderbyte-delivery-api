using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string? OrderDetails { get; set; }

        [Required]
        [StringLength(30)]
        public string? OrderStatus { get; set; }

        [Required]
        [StringLength(30)]
        public string? OrderDate { get; set; }

        [Required]
        [StringLength(20)]
        public string? OrderStartingTime { get; set; }

        [Required]
        [StringLength(20)]
        public string? OrderDeliveryTime { get; set; }

        [Required]
        public decimal OrderPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string? OrderLocation { get; set; }
        
        public List<Pizza>? Pizzas { get; set; }

    }
}
