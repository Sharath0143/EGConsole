using EGBuyDataBase;
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
    public class MenuManagement
    {
        private static readonly IMenuRepository IMenu= new MenuRepository();

        public static List<Menu> GetMenuItems()
        {
            return IMenu.GetMenuItems();
        }
        public static bool IsChoiceAvailable(int Choice)
        {
            return IMenu.GetMenuItems().Where(a => a.MenuId == Choice).Count() == 0 ? false : true;
        }
    }
}
