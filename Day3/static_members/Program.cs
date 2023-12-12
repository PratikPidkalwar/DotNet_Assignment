namespace static_members
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           
            Class1 c1= new Class1();
            c1.Display();
            Console.WriteLine(c1.i=90);


            Class2.Ss_i = 10;
            Console.WriteLine(Class2.Ss_i);

        }
    }

    public class Class1
    {
        public int i;

        //only a single copy for the entire class (shared data)
        public static int s_i;
        public void Display()
        {
            Console.WriteLine("Display");
            //Console.WriteLine(i);
            Console.WriteLine(s_i);

        }
    }

    public static class Class2
    {
       private static int ss_i;

        public static int Ss_i
        {
            set
            {
                if (value <= 100)
                    ss_i=value;
                else
                    Console.WriteLine("Invalid value for ss_i");
            }
            get
            {
                return ss_i;
            }
        }
    }
}