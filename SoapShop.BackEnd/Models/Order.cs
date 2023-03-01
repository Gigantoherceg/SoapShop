using System.ComponentModel.DataAnnotations;

namespace SoapShop.BackEnd.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        
        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        public ApplicationUser User { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
