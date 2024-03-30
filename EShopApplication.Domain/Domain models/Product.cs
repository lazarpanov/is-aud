using EShopApplication.Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShopApplication.Domain.Domain_models
{
    public class Product : BaseEntity
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductImage {  get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public double ProductRating { get; set; }
    }
}
