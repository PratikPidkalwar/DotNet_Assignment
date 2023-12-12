namespace InheritanceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           BaseClass o1=new BaseClass();
            o1.a = 1;

            DerivedClass o2=new DerivedClass();
            o2.b = 2; 
        }

        public class BaseClass
        {
            public int a;
        }
        public class DerivedClass:BaseClass
        {
            public int b;
        }
    }
}