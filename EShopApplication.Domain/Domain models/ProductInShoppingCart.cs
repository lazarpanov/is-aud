using System.ComponentModel.DataAnnotations;

namespace EShopApplication.Domain.Domain_models
{
    public class ProductInShoppingCart : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

        public Guid ShoppingCartId { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }

        public int Quantity { get; set; }
    }
}
