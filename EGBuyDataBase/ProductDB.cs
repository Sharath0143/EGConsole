using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyDataBase
{
    public class ProductDB
    {
        public List<Product> GetProductList()
        {
            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product { ProductId = 1, Name = "EGTV", Description="32' EG TV",Price=2000,CategoryId=1 });
            ProductList.Add(new Product { ProductId = 2, Name = "EGMobile", Description="Andriod 11",Price=1500,CategoryId = 1 });
            ProductList.Add(new Product { ProductId = 3, Name = "Tomatos", Description="Fresh veggies",Price=1500,CategoryId=3 });
            return ProductList;
        }
        public List<Menu> GetProductList(Guid ProductId)
        {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Menu { MenuId = 1, MenuName = "Categories" });
            MenuList.Add(new Menu { MenuId = 2, MenuName = "Products" });
            MenuList.Add(new Menu { MenuId = 3, MenuName = "Login" });
            return MenuList;
        }
        public List<Menu> AddProduct()
        {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Menu { MenuId = 1, MenuName = "Categories" });
            MenuList.Add(new Menu { MenuId = 2, MenuName = "Products" });
            MenuList.Add(new Menu { MenuId = 3, MenuName = "Login" });
            return MenuList;
        }
        public List<Menu> RemoveProduct(Guid ProductId)
        {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Menu { MenuId = 1, MenuName = "Categories" });
            MenuList.Add(new Menu { MenuId = 2, MenuName = "Products" });
            MenuList.Add(new Menu { MenuId = 3, MenuName = "Login" });
            return MenuList;
        }
        public List<Menu> UpdateProduct(Guid ProductId)
        {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Menu { MenuId = 1, MenuName = "Categories" });
            MenuList.Add(new Menu { MenuId = 2, MenuName = "Products" });
            MenuList.Add(new Menu { MenuId = 3, MenuName = "Login" });
            return MenuList;
        }
    }
}
