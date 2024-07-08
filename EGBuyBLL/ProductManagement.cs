using EGBuyDLL.Interface;
using EGBuyDLL.Repository;
using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyBLL
{
    public class ProductManagement
    {
        private static readonly IProductRepository IProduct = new ProductRepository();

        public static List<Product> GetProducts()
        {
            return IProduct.GetProducts();
        }
        public static List<Product> GetProducts(int CategoryId)
        {
            return IProduct.GetProducts(CategoryId);
        }
        public static List<Product> GetProductListByDiscount(string Coupon)
        {
            return IProduct.GetProducts();
        }
    }
}
