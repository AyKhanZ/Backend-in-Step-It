using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Kassa
{
    internal class UI
    {
        public Warehouse management = new();
        private bool flag = true;
        public bool Flag { get { return flag; } set { flag = value; } }
        public void ShowOptions()
        {

            Console.WriteLine("Options:" +
                "\n1)Add product" +
                "\n2)Delete product" +
                "\n3)Edit product" +
                "\n4)Make a purchase" +
                "\n5)Show products" +
                "\n6)Exit" +
                "\nEnter 1 - 6  >>> ");
            var choice1 = Convert.ToInt32(Console.ReadLine());
            if (choice1 > 0 && choice1 < 7)
            {
                if (choice1 == 1)
                {
                    management.AddGood();
                }
                else if (choice1 == 2)
                {
                    management.DeleteGood();
                }
                else if (choice1 == 3)
                {
                    management.EditGood();  
                }
                else if (choice1 == 4)
                {
                    management.MakeABuy();  
                }
                else if (choice1 == 5)
                {
                    foreach (var item in management.Goods)
                    {
                        Console.WriteLine($"Name: {item.Name}");
                        Console.WriteLine($"Price: {item.Price}");
                        Console.WriteLine($"Count: {item.Count}\n");
                    }
                }
                else if (choice1 == 6)
                {
                    flag = false;
                }

            }
            else Console.WriteLine("Wrong choice.Try again.");
        }


    }
}
