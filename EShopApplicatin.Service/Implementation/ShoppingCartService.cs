using EShopApplicatin.Service.Interface;
using EShopApplication.Domain.Domain_models;
using EShopApplication.Domain.DTO;
using EShopApplication.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopApplicatin.Service.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository<ShoppingCart> _shoppingCartRepository;
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<ProductInOrder> _productInOrderRepository;
        private readonly IRepository<ProductInShoppingCart> _productInShoppingCartRepository;
        private readonly IUserRepository _userRepository;

        public ShoppingCartService(IRepository<ShoppingCart> shoppingCartRepository, IRepository<Order> orderRepository, IRepository<ProductInOrder> productInOrderRepository, IRepository<ProductInShoppingCart> productInShoppingCartRepository, IUserRepository userRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _orderRepository = orderRepository;
            _productInOrderRepository = productInOrderRepository;
            _productInShoppingCartRepository = productInShoppingCartRepository;
            _userRepository = userRepository;
        }

        public bool addToShoppingConfirmed(ProductInShoppingCart model, string userId)
        {
            var user = this._userRepository.Get(userId);
            var shoppingCart = user.UserCart;
            ProductInShoppingCart itemToAdd = new ProductInShoppingCart()
            {
                Id = Guid.NewGuid(),
                Product = model.Product,
                ProductId = model.ProductId,
                ShoppingCart = shoppingCart,
                ShoppingCartId = model.ShoppingCartId,
                Quantity = model.Quantity,
            };
            _productInShoppingCartRepository.Insert(itemToAdd);
            return true;
        }

        public bool deleteProductFromShoppingCart(string userId, Guid productId)
        {
            if (!string.IsNullOrEmpty(userId) && productId != null) 
            {
                var loggedInUser = this._userRepository.Get(userId);
                var userShoppingCart = loggedInUser.UserCart;
                var itemToDelete = userShoppingCart.ProductInShoppingCarts.Where(z => z.ProductId.Equals(productId)).FirstOrDefault();
                userShoppingCart.ProductInShoppingCarts.Remove(itemToDelete);
                this._shoppingCartRepository.Update(userShoppingCart);
                return true;
            }
            return false;
        }

        public ShoppingCartDTO getShoppingCart(string userId)
        {
            var user = this._userRepository.Get(userId);
            var shoppingCart = user.UserCart;

            ShoppingCartDTO model = new ShoppingCartDTO()
            {
                AllProducts = shoppingCart.ProductInShoppingCarts ?? new List<ProductInShoppingCart>(),
                TotalPrice = shoppingCart.ProductInShoppingCarts.Sum(z => z.Quantity * z.Product.ProductPrice)
            };
            return model;
        }

        public bool order(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                var loggedInUser = this._userRepository.Get(userId);
                var userCard = loggedInUser.UserCart;

                Order order = new Order()
                {
                    Id = Guid.NewGuid(),
                    EShopApplicationUserId = Guid.Parse(userId),
                };
                this._orderRepository.Insert(order);

                List<ProductInOrder> productInOrders = new List<ProductInOrder>();

                var result = userCard.ProductInShoppingCarts.Select(z =>  new ProductInOrder
                {
                    Id = Guid.NewGuid(),
                    ProductId = z.ProductId,
                    OrderedProduct = z.Product,
                    Order = order,
                    Quantity = z.Quantity,
                    OrderId = order.Id
                }).ToList();

                StringBuilder sb = new StringBuilder();

                var totalPrice = 0.0;

                sb.AppendLine("Your order is completed. The order conatins: ");

                for (int i = 1; i <= result.Count(); i++)
                {
                    var currentItem = result[i - 1];
                    totalPrice += currentItem.Quantity * currentItem.OrderedProduct.ProductPrice;
                    sb.AppendLine(i.ToString() + ". " + currentItem.OrderedProduct.ProductName + " with quantity of: " + currentItem.Quantity + " and price of: $" + currentItem.OrderedProduct.ProductPrice);
                }

                sb.AppendLine("Total price for your order: " + totalPrice.ToString());

                //mail.Content = sb.ToString();


                productInOrders.AddRange(result);

                foreach (var item in productInOrders)
                {
                    this._productInOrderRepository.Insert(item);
                }

                loggedInUser.UserCart.ProductInShoppingCarts.Clear();

                this._userRepository.Update(loggedInUser);
                //this._mailRepository.Insert(mail);

                return true;
            }
            return false;
        }
    }
}
