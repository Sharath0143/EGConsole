using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyDataBase
{
    public class MenuDB
    {
        public List<Menu> GetMenuList() {
            List<Menu> MenuList = new List<Menu>();
            MenuList.Add(new Menu { MenuId = 1, MenuName = "Categories" });
            MenuList.Add(new Menu { MenuId = 2, MenuName = "Products" });
            MenuList.Add(new Menu { MenuId = 3, MenuName = "Login" });
            MenuList.Add(new Menu { MenuId = 4, MenuName = "Register" });
            MenuList.Add(new Menu { MenuId = 5, MenuName = "Clear" });
            return MenuList;
        }
    }
}
