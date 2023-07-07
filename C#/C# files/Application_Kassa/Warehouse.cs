using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application_Kassa
{
    internal class Warehouse
    {
        public List<Good> Goods = new();


        public void AddGood()
        {
            Console.WriteLine("Enter name of good: ");
            string name = Console.ReadLine() ?? "NoName";

            Console.WriteLine("Enter count of good: ");
            int count = 0;
            count = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter price of good: ");
            double money = 0;
            money = double.Parse(Console.ReadLine());



            if (name == "NoName")
            {
                Console.WriteLine("error! Name is empty! Please,try again");
            }
            else
            {
                bool Flag = false;
                foreach (Good good in Goods)
                {
                    if (good.Name == name)
                    {
                        Flag = true;
                        Console.WriteLine("Product with this name already exist! " +
                                          "Try again and enter another name! ");
                        break;
                    }
                }
                if (!Flag)
                {
                    // Good good1 = new(name, count, money); 
                    // Goods.Add(good1);
                    Goods.Add(new(name, count, money));


                    //JSON
                    var JsonFile = JsonSerializer.Serialize(Goods);
                    bool ExistOrNo = File.Exists("JsonFile.json");
                    if (!ExistOrNo)
                    {
                        using var file = File.Create("JsonFile.json");
                    }
                    using FileStream f = new FileStream("JsonFile.json", FileMode.Truncate);
                    StreamWriter s = new StreamWriter(f);
                    s.WriteLine(JsonFile);
                    s.Close();

                }
            }

        }


        public void DeleteGood()
        {
            // CHOICE
            Console.WriteLine("Enter number witch element you want to delete ?-> ");
            for (int i = 0; i < Goods.Capacity; i++)
            {
                Console.WriteLine($"{Goods[i].Name} - \'{i + 1}\'");
            }
            int index = Int32.Parse(Console.ReadLine());
            index--;
            if (index >= 0 && index < Goods.Count - 1)
            {
                Goods.RemoveAt(index);
                Console.WriteLine("Successfuly has deleted!");

                // JSON
                var JsonFile = JsonSerializer.Serialize(Goods);
                bool ExistOrNo = File.Exists("JsonFile.json");
                if (!ExistOrNo)
                {
                    using var file = File.Create("JsonFile.json");
                }
                using FileStream f = new FileStream("JsonFile.json", FileMode.Truncate);
                StreamWriter s = new StreamWriter(f);
                s.WriteLine(JsonFile);
                s.Close();
            }
            else Console.WriteLine("Error ! Index Out Of List");
        }


        public void EditGood()
        {

            // CHOICE
            Console.WriteLine("Enter number witch element you want to edit ?-> ");
            for (int i = 0; i < Goods.Capacity; i++)
            {
                Console.WriteLine($"{Goods[i].Name} - \'{i + 1}\'");
            }
            int index = Int32.Parse(Console.ReadLine());
            index--;
            if (index >= 0 && index < Goods.Count - 1)
            {
                Console.WriteLine("Enter number witch element you want to change ?-> ");
                Console.WriteLine("1)Name - \'1\'" +
                                  "\n2)Count - \'2\'" +
                                  "\n3)Price - \'3\'");


                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter a new name: ");
                        var name = Console.ReadLine();
                        if (!string.IsNullOrEmpty(name))
                        {
                            bool flag = true;
                            foreach(var item in Goods)
                            {
                                if (name == item.Name) flag = false;
                                Console.WriteLine("Good with this name is already exist! ");
                                break;
                            }
                             
                            if (flag) Goods[index].Name = name;

                        }
                        else
                        {
                            Console.WriteLine("Error! Name is empty! Please, try again");
                        }
                        break;                    
                    case 2:
                        Console.WriteLine("Enter count: ");
                        var count = Convert.ToInt32(Console.ReadLine());
                        if(count > 0) Goods[index].Count = count;   
                        else {
                            Console.WriteLine("Error! Count has to be > 0 !");
                        }
                        break; 
                    case 3:
                        Console.WriteLine("Enter price: ");
                        var price = Convert.ToSingle(Console.ReadLine());
                        if (price > 0) Goods[index].Price = price;
                        else
                        {
                            Console.WriteLine("Error! Price has to be > 0 !");
                        }

                        break;
                    default:
                        Console.WriteLine("Error! Choice is out of range! Please,try again");
                        break;
                }

                // JSON
                var JsonFile = JsonSerializer.Serialize(Goods);
                bool ExistOrNo = File.Exists("JsonFile.json");
                if (!ExistOrNo)
                {
                    using var file = File.Create("JsonFile.json");
                }
                using FileStream f = new FileStream("JsonFile.json", FileMode.Truncate);
                StreamWriter s = new StreamWriter(f);
                s.WriteLine(JsonFile);
                s.Close();
            }
            else Console.WriteLine("Error ! Index Out Of List");
        }
        

        public void MakeABuy()
        {
            for (int i = 0; i < Goods.Capacity; i++)
            {
                Console.WriteLine($"{i+1}) {Goods[i].Name}");
            }
            Console.WriteLine("Enter number of good that you want to buy: ");
            int ChoiceGood = Int32.Parse(Console.ReadLine()) - 1;
            if (ChoiceGood > 0 && ChoiceGood < Goods.Capacity) {
                Console.WriteLine($"Enter count of {Goods[ChoiceGood]} that you want to buy: ");
                var CountOfGood = Int32.Parse(Console.ReadLine());
                if (CountOfGood > 0 && CountOfGood < Goods[ChoiceGood].Count) {
                    Goods[ChoiceGood].Count -= CountOfGood;

                    //JSON
                    var JsonFile = JsonSerializer.Serialize(Goods);
                    bool ExistOrNo = File.Exists("JsonFile.json");
                    if (!ExistOrNo)
                    {
                        using var file = File.Create("JsonFile.json");
                    }
                    using FileStream f = new FileStream("JsonFile.json", FileMode.Truncate);
                    StreamWriter s = new StreamWriter(f);
                    s.WriteLine(JsonFile);
                    s.Close();

                }
                else Console.WriteLine("Error! Count can\'t be < 0 or > goods quantity");
            }
            else Console.WriteLine("Error! Your choice is out of range!");
        
        
        }
    }
}
