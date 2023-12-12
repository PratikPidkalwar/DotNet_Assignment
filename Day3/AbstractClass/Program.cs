namespace AbstractClass
{
    internal class Program
    {
        static void Main1(string[] args)
        {
           // Console.WriteLine("Hello, World!");
          // AbsClass1 a=new AbsClass1();
          //it gives error -we can not instance object
          DerivedClass d = new DerivedClass();
            d.Display();
        }
    }
    public abstract class AbsClass1
    {
        public void Display()
        {
            Console.WriteLine("display called from Abstract class");
        }
    }
    public class DerivedClass : AbsClass1
    {
       
    }
}

namespace AbstractClass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            // AbsClass1 a=new AbsClass1();
            //it gives error -we can not instance object
            DerivedClass d = new DerivedClass();
            d.Display();
            d.Show();
        }
    }
    public abstract class AbsClass2
    {
        public abstract void Display();
        public abstract void Show();
    }
    public class DerivedClass : AbsClass2
    {
        public override void Display()
        {
            Console.WriteLine("Display");
        }

        public override void Show()
        {
            Console.WriteLine("Show");
        }
    }
}