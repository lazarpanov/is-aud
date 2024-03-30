using EShopApplication.Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShopApplication.Domain.Domain_models
{
    public class ShoppingCart : BaseEntity
    {
        public Guid EshopApplicationUserId { get; set; }
        public virtual List<ProductInShoppingCart>? ProductInShoppingCarts { get; set; }

    }
}
