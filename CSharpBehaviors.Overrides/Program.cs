using System;

namespace CSharpBehaviors.Overrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1("bc.Method1");
            dc.Method1("dc.Method1");
            bcdc.Method1("bcdc.Method1");

            Console.WriteLine(string.Empty);

            bc.Method2("bc.Method2");
            dc.Method2("dc.Method2");
            bcdc.Method2("bcdc.Method2");

            Console.WriteLine(string.Empty);

            bc.Method3("bc.Method3");
            dc.Method3("dc.Method3");
            bcdc.Method3("bcdc.Method3");

            Console.WriteLine(string.Empty);

            bc.Method4("bc.Method4");
            dc.Method4("dc.Method4");
            bcdc.Method4("bcdc.Method4");

            Console.WriteLine(string.Empty);

            bc.Method5("bc.Method5");
            dc.Method5("dc.Method1");
            bcdc.Method5("bcdc.Method5");

            Console.ReadLine();
        }
    }

    public class BaseClass
    {
        public void Method1(string str)
        {
            Console.WriteLine($"Base class - Method1 // {str}");
        }

        public void Method2(string str)
        {
            Console.WriteLine($"Base class - Method2 // {str}");
        }

        public virtual void Method3(string str)
        {
            Console.WriteLine($"Base class - Method3 // {str}");
        }

        public virtual void Method4(string str)
        {
            Console.WriteLine($"Base class - Method4 // {str}");
        }

        public void Method5(string str)
        {
            Console.WriteLine($"Base class - Method5 // {str}");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void Method2(string str)
        {
            Console.WriteLine($"Derived class - Method2 // {str}");
        }

        public void Method3(string str)
        {
            Console.WriteLine($"Derived class - Method3 // {str}");
        }

        public override void Method4(string str)
        {
            Console.WriteLine($"Derived class - Method4 // {str}");
        }

        public new void Method5(string str)
        {
            Console.WriteLine($"Derived class - Method5 // {str}");
        }
    }
}
