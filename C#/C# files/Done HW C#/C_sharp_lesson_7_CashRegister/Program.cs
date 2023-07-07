using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json;

namespace CashRegister
{
    public class CashRegister
    {
        public static void Main()
        {

            Console.WriteLine("Choose option: \nConvert money - \'0\'\nWatch history - '1'\nEnd - '2'");
            int choice = Int32.Parse(Console.ReadLine());
            History history = new History();
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Enter count of money for converting: ");
                    int money = Convert.ToInt32(Console.ReadLine());
                    var result = new CurrentService(money);
                    result.ShowResult();

                    history.ToJson(result.GetList());
                    break;
                case 1:
                    history.ShowHistory();
                    break;  
                case 2:
                    Console.Clear();
                    Console.WriteLine("END!");
                    break;   
                default:
                    Console.Clear();
                    Console.WriteLine("Error! Choose 0 or 1 !\n");
                    Main();
                    break;

            }
        }
    }
}