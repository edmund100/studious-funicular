using System;

namespace virturalkeyword
{
    class MyBaseClass
    {
        public virtual void MyFunction()
        {
            Console.WriteLine("MyBaseClass:MyFunction");
            Console.WriteLine("\tYou can override this.");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public override void MyFunction()
        {
            Console.WriteLine("MyDerivedClass:MyFunction");
            base.MyFunction();
            Console.WriteLine("\tI'm override MyBaseFunction.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var myBaseClass = new MyBaseClass();
            myBaseClass.MyFunction();

            var myDerivedClass = new MyDerivedClass();
            myDerivedClass.MyFunction();
        }
    }
}
