using System;

namespace initkeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("can only assign in initializer");
            var initExample = new InitExample() { Seconds = 2 };

            Console.WriteLine(initExample.Seconds);
        }
    }
}
