using AvtoSalonConsoleApp.Data.DbContexts;
using AvtoSalonConsoleApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace AvtoSalonConsoleApp;
class Program
{
    static void Main(string[] args)
    { 
        while (true)
        { 
            using (AvtosalonContext avtosalonContext = new())
            {
                Console.WriteLine(
                    "Add avto - \'1\'" +
                    "\nDelete avto - \'2\'" +
                    "\nEdit avto - \'3\'" +
                    "\nShow all avto in avtosalon - \'4\'" +
                    "\nExit - \'5\'" +
                    "\nEnter your choice --->>>");
                int choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter avto name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter avto mark:");
                    string mark = Console.ReadLine();
                    Console.WriteLine("Enter avtosalon id:");
                    int avtoId = Int32.Parse(Console.ReadLine());

                    var avto = new Avto { Name = name, Mark = mark, AvtosalonId = avtoId};
                    avtosalonContext.Add(avto);
                    avtosalonContext.SaveChanges();
                    Console.WriteLine("Sucessed!");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter avto name for delete:");
                    string nameDelete = Console.ReadLine();
                    var avtoToDelete = avtosalonContext.Avtoes.FirstOrDefault(avt => avt.Name == nameDelete);
                    if (avtoToDelete != null)
                    {
                        avtosalonContext.Avtoes.Remove(avtoToDelete);
                        avtosalonContext.SaveChanges();
                    }
                    Console.WriteLine("Sucessed!");
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter avto name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter avto mark:");
                    string mark = Console.ReadLine();
                    Console.WriteLine("Enter avtosalon id:");
                    int avtoId = Int32.Parse(Console.ReadLine());

                    var avtoToDelete = avtosalonContext.Avtoes.FirstOrDefault(avt => (avt.Name == name && avt.Mark == mark && avt.AvtosalonId == avtoId));
                    if (avtoToDelete != null)
                    {
                        avtosalonContext.Avtoes.Remove(avtoToDelete);
                        avtosalonContext.SaveChanges();
                    }

                    Console.WriteLine("Enter new avto name:");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Enter new avto mark:");
                    string newMark = Console.ReadLine();
                    Console.WriteLine("Enter new avtosalon id:");
                    int newAvtoId = Int32.Parse(Console.ReadLine());
                    var avto = new Avto { Name = newName, Mark = newMark, AvtosalonId = newAvtoId };

                    avtosalonContext.Add(avto);
                    avtosalonContext.SaveChanges();
                    Console.WriteLine("Sucessed!");
                }
                else if (choice == 4) 
                {
                    Console.Clear();
                    var avtosalons = avtosalonContext.Avtosalons.Include(a => a.Avtoes).ToList();
                    foreach (var avtosalon in avtosalons)
                    {
                        Console.WriteLine($"Avtosalon: {avtosalon.Name}");
                        foreach (var avto in avtosalon.Avtoes)
                        {
                            Console.WriteLine($"Avto: {avto.Name}");
                        }
                        Console.WriteLine("");
                    }
                }
                else if (choice == 5) { Console.Clear(); Console.WriteLine("Exit"); break; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error!\nChoose only 1 ,2 or 3!!!");
                }
            }
        }
    }
}