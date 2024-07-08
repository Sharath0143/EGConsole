using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyDataBase
{
    public class CategoryDB
    {
        public List<Category> GetCategoryList()
        {
            List<Category> CategoryList = new List<Category>();
            CategoryList.Add(new Category { CategoryId = 1, Name = "Electronics", Description="Electronic gadgets" });
            CategoryList.Add(new Category { CategoryId = 2, Name = "Grocery", Description="Grocery Products" });
            CategoryList.Add(new Category { CategoryId = 3, Name = "Home & Furniture", Description="Home and Furniture" });
            return CategoryList;
        }
    }
}
