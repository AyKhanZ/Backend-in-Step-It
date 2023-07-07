using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lesson_5
{
    class MoneyClass
    {
        protected string valuta { get; set; }
        protected int cash { get; set; }
        protected int penny { get; set; }

        public MoneyClass(string valuta,int cash ,int penny)
        {
            this.valuta = valuta;this.cash = cash;this.penny = penny;  
        }
        public double SumOfMoney(int cash, int penny) {
            double allMoney = cash + penny / 100 + (penny % 100) * 0.01; 
            return allMoney;
        }

    }
    internal class ProductClass : MoneyClass
    {
        private int PriceOfProduct = 1000; 
        public ProductClass(string valuta, int cash, int penny):base(valuta,cash,penny) {  }

        public void LowMoney(int LowPrice) {
            Console.WriteLine($"\nProduct cost: {PriceOfProduct}");
            PriceOfProduct -= LowPrice; 
            Console.WriteLine($"\nNow product cost: {PriceOfProduct} ");
        }
        

        public void Show() { Console.WriteLine($"\nThere are {cash + penny / 100}.{penny % 100} {valuta}"); }
        


    }
} 