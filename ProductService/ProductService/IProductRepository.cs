using System.Collections.Generic;

namespace ProductService
{
    public interface IProductRepository
    {
        IList<Product> GetAllProductsIn(int categoryId);
    }
}