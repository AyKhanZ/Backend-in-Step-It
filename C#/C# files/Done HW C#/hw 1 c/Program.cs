using System;

namespace hw {
    class Program {
        static void Main()
        {
            //Task 1
            Console.WriteLine("Task 1\nEnter num -> ");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            if (a <= 100 && a >= 1) {
                if (a % 3 == 0 && a % 5 == 0) Console.WriteLine("Fizz Buzz");
                else if (a % 5 == 0) Console.WriteLine("Buzz");
                else if (a % 3 == 0) Console.WriteLine("Fizz");
                else Console.WriteLine(a);
            }
            else Console.WriteLine("Error");
            //-------------------------------------------------------------------------
            //Task 2
            Console.WriteLine("Task 2\nEnter num -> ");
            string line2 = Console.ReadLine();
            int a2 = int.Parse(line2);

            Console.WriteLine("Enter % -> ");
            string line3 = Console.ReadLine();
            int a3 = int.Parse(line3);

            Console.WriteLine($"-> {(a2 * a3)/100}");

            //-------------------------------------------------------------------------
            //Task 3
            Console.WriteLine("task 3\nenter num -> ");
            string line4 = Console.ReadLine();
            int a4 = int.Parse(line4);

            Console.WriteLine("enter num -> ");
            string line5 = Console.ReadLine();
            int a5 = int.Parse(line5);

            Console.WriteLine("enter num -> ");
            string line6 = Console.ReadLine();
            int a6 = int.Parse(line6);

            Console.WriteLine("enter num -> ");
            string line7 = Console.ReadLine();
            int a7 = int.Parse(line7);

            int res = a4 * 1000 + a5 * 100 + a6 * 10 + a7;
            Console.WriteLine($"=> {res}");

            //--------------------------------------------------------------------------
            //Task 4 
            int six_dig_number = 0;
            bool flag = true;

            while (flag == true)
            {
                Console.WriteLine("TASK 4\nEnter six-diget num > ");
                six_dig_number = Convert.ToInt32(Console.ReadLine());
                if (six_dig_number / 100000 == 0) { Console.WriteLine("Error"); continue; }
                else flag = false;
            }


            Console.WriteLine("Enter first -> ");
            string line_c_ = Console.ReadLine();
            int first = int.Parse(line_c_); 

            Console.WriteLine("Enter second -> ");
            string line_d_ = Console.ReadLine();
            int second = int.Parse(line_d_);

            int num1 = six_dig_number / 100000;
            int num2 = six_dig_number % 100000 / 10000;
            int num3 = six_dig_number % 10000 / 1000;
            int num4 = six_dig_number % 1000 / 100;
            int num5 = six_dig_number % 100 / 10;
            int num6 = six_dig_number % 10;

            int r_1, r_2, num__1, num__2 ;
            r_1 = r_2 = num__1 = num__2 = 0;

            if (first == 1) { six_dig_number -= num1 * 100000; r_1 = 100000; num__1 = num1; }
            else if (first == 2) { six_dig_number -= num2 * 10000; r_1 = 10000; num__1 = num2; }
            else if (first == 3) { six_dig_number -= num3 * 1000; r_1 = 1000; num__1 = num3; }
            else if (first == 4) { six_dig_number -= num4 * 100; r_1 = 100; num__1 = num4; }
            else if (first == 5) { six_dig_number -= num5 * 10; r_1 = 10; num__1 = num5; }
            else if (first == 6) { six_dig_number -= num6; r_1 = 1; num__1 = num6; }

            if (second == 1) { six_dig_number -= num1 * 100000; r_1 = 100000; num__2 = num1; }
            else if (second == 2) { six_dig_number -= num2 * 10000; r_2 = 10000; num__2 = num2; }
            else if (second == 3) { six_dig_number -= num3 * 1000; r_2 = 1000; num__2 = num3; }
            else if (second == 4) { six_dig_number -= num4 * 100; r_2 = 100; num__2 = num4; }
            else if (second == 5) { six_dig_number -= num5 * 10; r_2 = 10; num__2 = num5; }
            else if (second == 6) { six_dig_number -= num6; r_2 = 1; num__2 = num6; }
            
            six_dig_number += num__2 * r_1 + num__1 * r_2;
            Console.WriteLine($"\nResult -> {six_dig_number}");
            //---------------------------------------------------------------------------------------
            //Task 5
            Console.WriteLine("Task 5\n" +
                "Enter day -> ");
            int year, mounth, day;
            string line__ = Console.ReadLine();
            day = int.Parse(line__);

            Console.WriteLine("Enter month -> ");
            string line__2 = Console.ReadLine();
            mounth = int.Parse(line__2);

            Console.WriteLine("Enter year -> ");
            string line__3 = Console.ReadLine();
            year = int.Parse(line__3);

            string sezon = "";
            if (mounth == 12 || mounth == 1 || mounth == 2) sezon = "winter";
            else if (mounth == 3 || mounth == 4 || mounth == 5) sezon = "spring";
            else if (mounth == 6 || mounth == 7 || mounth == 8) sezon = "summer";
            else if (mounth == 9 || mounth == 10 || mounth == 11) sezon = "autumn";
            DateTime dt = new DateTime(year, mounth, day);
            Console.WriteLine($"{dt} \n=> {sezon} {dt.DayOfWeek}");
            //-------------------------------------------------------------------------
            // Task 6
            Console.WriteLine(
                "Task 6\n" +
                "1)F to C\n" +
                "2)C to F \nEnter 1 or 2 -> ");

            string line_ = Console.ReadLine();
            int var1 = int.Parse(line_); 
            if(var1 == 1) {
                Console.WriteLine("\nEnter F -> ");
                string lineF = Console.ReadLine();
                int varF = int.Parse(lineF);
                int C = 0;
                C = (5 / 9) * (varF - 32) ;
                Console.WriteLine($"C = {C} ");
            }
            else if(var1 == 2) {
                Console.WriteLine("\nEnter C -> ");
                string lineC = Console.ReadLine();
                int varC = int.Parse(lineC);
                int F = 0;
                F = ((9 / 5) * varC )+32;
                Console.WriteLine($"F = {F} ");
            }

            //-------------------------------------------------------------------------
            //Task 7
            Console.WriteLine("Task 7\nEnter start diapazon -> ");
            string line_7 = Console.ReadLine();
            int a_7 = int.Parse(line_7);            
            Console.WriteLine("Enter end diapazon -> ");
            string line8 = Console.ReadLine();
            int a8 = int.Parse(line8);
            if(a_7 < a8) {
                int i = 0;
                if (a_7 > 1) i = a_7;
                else i = 2;
                for (; i < a8; i++) if(i%2 == 0) Console.WriteLine($"{i} ");
            }
            else {
                int g = a_7;
                a_7 = a8;
                a8 = g;
                for (int i = a_7; i < a8; i++) if (i % 2 == 0) Console.WriteLine($"{i} ");
            }


        }
    }                               
}                                   
                                    
                              