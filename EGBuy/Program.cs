using EGBuyBLL;
using EGBuyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EGBuy
{
    public class Program
    {
        static void Main(string[] args)
        {
            LoadDashboard();
            LoadDeals();
            LoadMenu();
            Console.ReadKey();
        }
        private static void LoadDashboard()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("                                         EGBUY                                           ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
        }
        private static void LoadDeals()
        {
            try
            {
                List<Product> ProductList = ProductManagement.GetProductListByDiscount("DEALS");
                if (ProductList.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("*** DEALS FOR TODAY ***  ");
                    Console.ResetColor();
                    Console.WriteLine("Use coupon code DEAL20 to get flat 20% discount on below products");
                    Console.WriteLine(Environment.NewLine);
                    foreach (Product product in ProductList)
                    {
                        Console.Write("\t"+product.Name+"\t");
                    }
                    Console.WriteLine(Environment.NewLine);
                }
                else
                {
                    //Top deals bool  variable on and off
                }
            }
            catch(Exception ex)
            {
                //Do nothing. No Product will be loading
            }
        }

        private static void LoadMenu()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("MENU                                           ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            List<Menu> MenuList = MenuManagement.GetMenuItems();
            if (MenuList.Count > 0)
            {
                foreach (Menu menu in MenuList)
                {
                    Console.WriteLine("{0} - {1}",menu.MenuId,menu.MenuName);
                }
                Console.WriteLine("Select your choice and hit enter");
                int Choice = 0;
                int.TryParse(Console.ReadLine(),out Choice);
                if(Choice > 0 && Choice <= MenuList.Count)
                {
                    Console.Clear();
                    LoadDashboard();
                    switch (Choice)
                    {
                        case 1:
                            DashboardMenu.LoadCategories();
                            break;
                        case 2:
                            DashboardMenu.LoadCategories();
                            break;
                        case 3:
                            DashboardMenu.LoadCategories();
                            break;
                        case 4:
                            DashboardMenu.LoadCategories();
                            break;
                        default:
                            DashboardMenu.LoadCategories();
                            break;
                    }       
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid selection. Please try again.");
                    LoadMenu();
                }
            }
        }
    }
}
