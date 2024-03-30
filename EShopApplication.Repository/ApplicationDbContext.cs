using EShopApplication.Domain.Domain_models;
using EShopApplication.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EShopApplication.Repository
{
    public class ApplicationDbContext : IdentityDbContext<EShopApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } = default!;
        public DbSet<ProductInShoppingCart> ProductInShoppingCarts { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<ProductInOrder> ProductInOrders { get; set; } = default!;
    }
}
