using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static Task? _task;

        static void Main(string[] args)
        {
            Doit();

        }

        static void Doit()
        {
            Doit_Async();
            while (_task != null && !_task.IsCompleted)
            {
                Thread.Sleep(100);
            }
        }

        async static void Doit_Async()
        {
            Console.WriteLine("Start: Doit_Async");
            Thread.Sleep(1000);
            _task = Task.Run(() => DoThis());
            await _task;
            Doit_Async_Helper();
            Console.WriteLine("End: Doit_Async");
        }

        static void Doit_Async_Helper()
        {
            Console.WriteLine("Doit_Async_Helper");
        }

        static void DoThis()
        {
            Console.WriteLine("DoThis");
            Thread.Sleep(500);
        }
    }
}