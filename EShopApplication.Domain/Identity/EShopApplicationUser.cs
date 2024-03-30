using EShopApplication.Domain.Domain_models;
using Microsoft.AspNetCore.Identity;

namespace EShopApplication.Domain.Identity
{
    public class EShopApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ShoppingCart UserCart { get; set; }
        public virtual ICollection<Product> MyProducts { get; set; }
    }
}
