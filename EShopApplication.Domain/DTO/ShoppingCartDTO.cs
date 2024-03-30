using EShopApplication.Domain.Domain_models;

namespace EShopApplication.Domain.DTO
{
    public class ShoppingCartDTO
    {
        public List<ProductInShoppingCart> AllProducts { get; set; }
        public double TotalPrice { get; set; }
    }
}
