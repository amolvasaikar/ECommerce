using Skinet.Library.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Skinet.Library.Interface
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        //Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        //Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}
