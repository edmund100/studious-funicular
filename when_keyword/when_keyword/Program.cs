using System;
using System.Collections.Generic;

namespace when_keyword
{
    class Program
    {
        private static void ShowWhenInException()
        {
            // Use when in an exception.
            Console.WriteLine("Use when in an exception.\n");
            try
            {
                throw new Exception("This is my awesome exception.");
            }
            catch (Exception exception) when (exception.Message.Contains("awesome"))
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void ShowWhenInSwitchStatement()
        {
            // Use when in a switch statment.
            Console.WriteLine("Use when in a switch statement.\n");
            var number = 2;

            switch (number)
            {
                case int x when x < 5 && x > 0:
                    Console.WriteLine("The value is less than 5 but greater " +
                            "than 0 according to this when condition in this switch statement.");
                    break;
            }

            switch (number)
            {
                case > 0:
                    Console.WriteLine("The value is greater " +
                            "than 0 according to this when condition in this switch statement.");
                    break;
            }
        }

        private static void ShowWhenInSwitchExpression()
        {
            // Use when in a switch expression.
            Console.WriteLine("Use when in a switch expression.\n");

            var number1 = 3;
            var number2 = 3;

            switch ((number1, number2))
            {
                case ( > 0, > 0) when number1 == number2:
                    Console.WriteLine($"Both measurements are valid and equal to {number1}.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            var list = new List<Action>();
            list.Add(new Action(ShowWhenInException));
            list.Add(new Action(ShowWhenInSwitchStatement));
            list.Add(new Action(ShowWhenInSwitchExpression));

            foreach (var item in list)
            {
                item();
                if (list.IndexOf(item) < list.Count - 1)
                {
                    Console.WriteLine("\n----------------\n");
                }
            }
        }
    }
}
