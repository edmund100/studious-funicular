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

            var task1 = Task.Run(() => CallThis(1));
            var task2 = Task.Run(() => CallThis(2));
            var task3 = Task.Run(() => CallThis(3));

            while (!task1.IsCompleted || !task2.IsCompleted || !task3.IsCompleted)
            {
                Thread.Sleep(1000);
            }

        }

        static void CallThis(int callindex)
        {
            Console.WriteLine("start CallThis: " + callindex + ", " + DateTime.Now.ToLongTimeString());
            lock (myLock)
            {
                Console.WriteLine("inside lock " + callindex + ", " + DateTime.Now.ToLongTimeString());
                Thread.Sleep(2000);
            }

            Console.WriteLine("stop CallThis: " + callindex + " " + DateTime.Now.ToLongTimeString());
        }
    }
}
