using EShopApplication.Domain.Domain_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopApplicatin.Service.Interface
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetDetailsForProduct(Guid? id);
        void CreateNewProduct(Product product);
        void UpdateExistingProduct(Product product);
        void DeleteProduct(Guid id);
    }
}
