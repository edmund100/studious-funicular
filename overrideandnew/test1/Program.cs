using System;

namespace test1
{
    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("Base - Method3");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Method1()
        {
            base.Method1();
            Console.WriteLine("- Derived - Method1");
        }

        public new void Method2()
        {
            base.Method2();
            Console.WriteLine("- Derived - Method2");
        }

        public override void Method3()
        {
            base.Method3();
            Console.WriteLine("- Derived - Method3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1();
            bc.Method2();
            bc.Method3();
            // Output:  
            // Base - Method1  
            // Base - Method2  
            // Base - Method3

            Console.WriteLine();

            dc.Method1();
            dc.Method2();
            dc.Method3();
            // Output:  
            // Based - Method1, Derived - Method1  
            // Based - Method2, Derived - Method2  
            // Based - Method3, Derived - Method3  

            Console.WriteLine();

            bcdc.Method1();
            bcdc.Method2();
            bcdc.Method3();
            // Output:  
            // Based - Method1
            // Base - Method2  
            // Base - Method3, Derived - Method3 
        }
    }
}
