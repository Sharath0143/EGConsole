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
    public class MenuRepository : IMenuRepository
    {
        private readonly MenuDB Menu;
        public MenuRepository()
        {
              Menu = new MenuDB();
        }
        public List<Menu> GetMenuItems()
        {
            return Menu.GetMenuList();
        }
    }
}
