using System;

namespace ClassBasics
{
    public class Program
    {
        static void Main()
        {
            //MyNamespace.N2.Class3
            //Console.WriteLine("Hello, World!");
            //System.Console.WriteLine("HW");
            System.Console.WriteLine("HW");
            Console.WriteLine("HW");

        }
    }
}

namespace MyNamespace
{
    public class Class1 
    {
        static void Main1()
        {
            //MyNamespace.N2.Class3
            Console.WriteLine("Hello, World!2");
        }
    }
    public class Class2
    {
        
    }
    namespace N2
    {
        public class Class3 { }
    }
}

namespace Cricket
{
    public class Player { }
    public class Manager { }
}

namespace Office
{
    public class Employee{ }
    public class Manager { }
}

