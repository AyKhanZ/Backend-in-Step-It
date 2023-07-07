using System;
using System.Collections.ObjectModel;
using System.Threading;
namespace WpfSystemApp2.Services.Classes;
public static class FibonachyNumbers
{
    public static CancellationTokenSource Cts = new();
    public static CancellationToken Token = Cts.Token;
    public static ManualResetEvent PauseEvent = new(true);
    public static bool IsPaused { get; set; } = false;
    public static void PrintFibonachyNumbers(int FidonachyNum, ObservableCollection<int> FibonachyNums)
    {
        int a0 = 0, a1 = 1, NextNum = 0;
        App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
        {
            FibonachyNums.Add(a0);
            Thread.Sleep(500);
            FibonachyNums.Add(a1);
            Thread.Sleep(500);
        });
        if (FidonachyNum != 0)
        { 
            for (int i = 2; i < FidonachyNum;)
            {
                PauseEvent.WaitOne(); // Ожидаем сигнала продолжения работы потока
                NextNum = a0 + a1;
                App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
                {
                    FibonachyNums.Add(NextNum);
                });
                a0 = a1;
                a1 = NextNum;
                i++;
                Thread.Sleep(500);
            }
        }
        else
        {
            while (!Token.IsCancellationRequested)
            { 
                for (int i = 2;;)
                {
                    PauseEvent.WaitOne(); // Ожидаем сигнала продолжения работы потока
                    NextNum = a0 + a1;
                    App.Current.Dispatcher.Invoke((Action)delegate // <--- HERE
                    {
                        FibonachyNums.Add(NextNum);
                    });
                    a0 = a1;
                    a1 = NextNum;
                    i++;
                    Thread.Sleep(500);
                }
            }
        }
    }
}