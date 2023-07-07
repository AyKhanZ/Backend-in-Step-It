using C_sharp_lesson_5;
using System;
using System.Text;

namespace Program
{

    class Program {
        public static void Main()
        {
            #region Task 1
            Console.WriteLine("---------------------- Task 1 ----------------------");
            Console.WriteLine("Enter valuta: ");
            string valuta = Console.ReadLine() ?? "AZN";

            Console.WriteLine("Enter how much monney without penney you wanna put: ");
            int cash = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how much penney you wanna put: ");
            int penny = Convert.ToInt32(Console.ReadLine());

            var product1 = new ProductClass(valuta, cash, penny);

            product1.Show();

            Console.WriteLine("Enter price for reduce the price of the product: ");
            int price = Convert.ToInt32(Console.ReadLine());
            product1.LowMoney(price);

            Console.WriteLine($"\nSum of your money is {product1.SumOfMoney(cash, penny)} {valuta}");

            #endregion



            #region Task 2
            Console.WriteLine("---------------------- Task 2 ----------------------"); 
            KettleClass device1 = new(); 
            device1.Desc();
            device1.Sound();
            device1.Show();
            Console.WriteLine('\n');

            MicrowaveClass device2 = new(); 
            device2.Desc();
            device2.Sound();
            device2.Show();
            Console.WriteLine('\n');

            CarClass device3 = new(); 
            device3.Desc();
            device3.Sound();
            device3.Show();
            Console.WriteLine('\n');

            SteamboatClass device4 = new(); 
            device4.Desc();
            device4.Sound();
            device4.Show();
            Console.WriteLine('\n');
            #endregion



            #region Task 3
            Console.WriteLine("---------------------- Task 3 ----------------------");
            violin tool1 = new();
            tool1.History();
            tool1.Desc();    
            tool1.Sound();
            tool1.Show();
            Console.WriteLine('\n');

            Trombone tool2 = new();
            tool2.History();
            tool2.Desc();    
            tool2.Sound();
            tool2.Show();
            Console.WriteLine('\n');

            Ukulele tool3 = new();
            tool3.History();
            tool3.Desc();    
            tool3.Sound();
            tool3.Show();
            Console.WriteLine('\n');
            #endregion


            #region Task 4
            Console.WriteLine("---------------------- Task 4 ----------------------");
            President worker1 = new();
            worker1.Print();
            Console.WriteLine('\n');

            Security worker2 = new();
            worker2.Print();
            Console.WriteLine('\n');

            Manager worker3 = new();
            worker3.Print();
            Console.WriteLine('\n');

            Engineer worker4 = new();
            worker4.Print();
            Console.WriteLine('\n');
            #endregion
        }
    }
}