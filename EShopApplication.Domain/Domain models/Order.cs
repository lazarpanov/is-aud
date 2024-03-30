using EShopApplication.Domain.Identity;
using System.ComponentModel.DataAnnotations;

namespace EShopApplication.Domain.Domain_models
{
    public class Order : BaseEntity
    {
        public Guid EShopApplicationUserId { get; set; }
        public virtual ICollection<ProductInOrder>? ProductInOrders { get; set; }
    }
}
