using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyDLL.Interface
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        List<Product> GetProducts(int CategoryId);
        Product GetProduct(int ProductId);

    }
}
