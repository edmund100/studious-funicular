using System;
using System.Threading.Tasks;
using System.Threading;

namespace lockstatement
{
    class Lock
    {
    }

    class Program
    {
        private static Lock myLock = new Lock();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myLock = new Lock();

            var task1 = Task.Run(() => DoThis(1));
            var task2 = Task.Run(() => DoThis(2));
            var task3 = Task.Run(() => DoThis(3));

            while (!task1.IsCompleted || !task2.IsCompleted || !task3.IsCompleted)
            {
                Thread.Sleep(1000);
            }

        }

        static void DoThis(int callindex)
        {
            Console.WriteLine("Start " + callindex + ", " + DateTime.Now.ToLongTimeString());
            lock (myLock)
            {
                Console.WriteLine("inside lock for " + callindex + ", " + DateTime.Now.ToLongTimeString());
                Thread.Sleep(5000);
            }

            Console.WriteLine("Stop " + callindex + " " + DateTime.Now.ToLongTimeString());
        }
    }
}
