using EGBuyDataBase;
using EGBuyDLL.Interface;
using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyDLL.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly ProductDB Product;
        public ProductRepository()
        {
            Product = new ProductDB();
        }
        public List<Product> GetProducts()
        {
            return Product.GetProductList();
        }
        public Product GetProduct(int ProductId)
        {
            return Product.GetProductList().Where(a => a.ProductId == ProductId).FirstOrDefault();
        }

        public List<Product> GetProducts(int CategoryId)
        {
            var result= Product.GetProductList().Where(a => a.CategoryId == CategoryId).ToList();
            return result;
        }
    }
}
