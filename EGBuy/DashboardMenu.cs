using EGBuyBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EGBuy
{
    public class DashboardMenu
    {
        public static void LoadCategories()
        {
            var Categories=CategoryManagement.GetCategories();
            if(Categories.Count > 0 )
            {
                for(int i=0;i<Categories.Count; i++)
                {
                    var category = Categories[i];
                    Console.WriteLine(category.CategoryId+ " - "+category.Name);
                }
                Console.WriteLine("Select your choice and hit enter");
                int Choice = 0;
                int.TryParse(Console.ReadLine(), out Choice);
                if (Choice>0&&Choice<=Categories.Count)
                {
                    LoadProducts(Choice);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }
        }
        public static void LoadProducts(int Choice)
        {
            var Products = ProductManagement.GetProducts(Choice);
            for (int i = 0; i < Products.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ProductNumber {0}{1}ProductName {2}{3}Description{4}{5}Price {6}", Products[i].ProductId,Environment.NewLine, Products[i].Name,Environment.NewLine, Products[i].Description,Environment.NewLine, Products[i].Price);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----------------------------------------------------------------------------------------");
                Console.ResetColor();
            }
        }
    }
}
