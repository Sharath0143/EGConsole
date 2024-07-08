using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGBuyDLL.Interface
{
    public interface IMenuRepository
    {
       List<Menu> GetMenuItems();
    }
}
