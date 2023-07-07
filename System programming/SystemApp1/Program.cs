using System;
using System.Diagnostics;

namespace ProcessDemo
{
    class Program
    {
        static void Main()
        {
            // - - - - - - - - - - - - - - - - Task 1 - - - - - - - - - - - - - - - -
            Process process = new Process();

            // Установка имени исполняемого файла для запуска
            process.StartInfo.FileName = "notepad.exe"; 

            // Запуск процесса
            process.Start();

            // Ожидание завершения процесса
            process.WaitForExit();

            // Вывод кода завершения в консоль
            Console.WriteLine($"Kod end {process.ExitCode}");
            // - - - - - - - - - - - - - - - - Task 2 - - - - - - - - - - - - - - - -
            process.StartInfo.FileName = "notepad.exe";

            process.Start();

            Console.WriteLine("Wait the finish of the process - \'1\'\nFinish the process - \'2\'");
            int choice = Int32.Parse(Console.ReadLine());

            if (choice == 1) process.WaitForExit();
            else process.Kill();

            Console.WriteLine($"Kod end {process.ExitCode}");
        }
    }
}