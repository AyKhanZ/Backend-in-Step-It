using C_sharp_lesson_4;

namespace Program {
    public class Program {

        static void Main() {

            ArrayClass arr = new ArrayClass();

            arr.Show();

            int Choice = 0;
            Console.Write("Enter number for compare: ");
            Choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Count of less than {Choice} : { arr.Less(Choice)}");

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Count of greater than {Choice} : { arr.Greater(Choice)}");
            arr.ShowEven();
            arr.ShowOdd();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine($"Count of numbers which are distinct :\t {arr.CountDistinct()}");
            Console.WriteLine($"Count of numbers which compare {Choice} :\t {arr.EqualToValue(Choice)}");
        }
    }
}
