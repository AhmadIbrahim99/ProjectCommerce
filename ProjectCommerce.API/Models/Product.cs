using System.ComponentModel.DataAnnotations;

namespace ProjectCommerce.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float Cost { get; set; }
    }
}
