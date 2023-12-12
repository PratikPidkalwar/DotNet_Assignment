namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Class1 c = new Class1();
            Console.WriteLine(c.i);

            Class1 c2 = new Class1();
            Console.WriteLine(c2.i);
        }
    }

    public class Class1
    {
        public int i;

        public Class1()
        {
            Console.WriteLine("constructor Class1");
            i = 10;
        }
        public Class1(int i=10)
        {
            Console.WriteLine("parametrise constructor");
            this.i = i; //this is reference to the current object.
        }
    }
}