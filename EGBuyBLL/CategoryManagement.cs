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
    public class CategoryManagement
    {
        private static readonly ICategoryRepository ICategory = new CategoryRepository();
        public static List<Category> GetCategories()
        {
            return ICategory.GetCategories();
        }
        public static bool IsChoiceAvailable(int Choice,List<Category> CategoryList)
        {
            try
            {
                var Category= CategoryList[Choice-1];
                //return ICategory.GetCategories().Where(a => a.CategoryId == Choice).Count() == 0 ? false : true;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                return false;
            }
            return false;
        }
    }
}
