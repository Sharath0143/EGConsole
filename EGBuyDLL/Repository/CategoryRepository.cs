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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CategoryDB Category;
        public CategoryRepository()
        {
            Category = new CategoryDB();
        }
        public List<Category> GetCategories()
        {
            return Category.GetCategoryList();
        }
    }
}
