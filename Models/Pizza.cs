using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaAPI.Models
{
    [Table("Pizza")]
    public class Pizza
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PizzaId { get; set; }

        [Required]
        public PizzaType PizzaType { get; set; }

        [Required]
        [StringLength(30)]
        public string? PizzaDescription { get; set; }
        
        [ForeignKey("OrderId")]
        public Guid OrderId { get; set; }
    }

    public enum PizzaType
    {
        Cheese,
        Veggie,
        GlutenFree,
        BBQChicken,
        Pepperoni,
        MeatLover,
        Mediterranean,
        Pesto
    }
}
