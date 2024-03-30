using EShopApplication.Domain.Domain_models;
using EShopApplication.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopApplicatin.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDTO getShoppingCart(string userId);
        bool deleteProductFromShoppingCart(string userId, Guid productId);
        bool order(string userId);
        bool addToShoppingConfirmed(ProductInShoppingCart model, string userId);
    }
}
