using System;
using System.Text; 

namespace C_sharp_lesson_4
{
    public class ArrayClass : ICalc , IOutput2 , ICalc2 {
        int[] arr = new int[10] ;

        Random random = new Random();
        // ctor
        public ArrayClass() {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = random.Next(0,20);
            }
        }
        public void Show() {
            Console.WriteLine($"Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"[{i}] = {arr[i]}");
            }
        }
        // ICalc
        public int Less(int valueToCompare) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] < valueToCompare) count++;
            }
            return count;
        }
        public int Greater(int valueToCompare) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > valueToCompare) count++;
            }
            return count;
        }
        // IOutput2
        public void ShowEven()
        {
            Console.WriteLine("Even numbers in array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] != 0) Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\n");
        }
        public void ShowOdd()
        {
            Console.WriteLine("Odd numbers in array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0) Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine("\n");
        }
        // ICalc2
        public int CountDistinct()
        {
            int СountOfUnique = 0;

            int[] arr2 = arr;
            int a = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr[i] == arr2[j]) a++;
                }
                if (a == 1) СountOfUnique++;
                a = 0;
            }
            return СountOfUnique;
        }
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valueToCompare) count++;
            }
            return count;
        }

    }
}
