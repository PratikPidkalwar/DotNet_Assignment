namespace InheritanceExample3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           DerivedClass d=new DerivedClass();
            DerivedClass d = new DerivedClass(123,456);
        }
    }

    public class BaseClass
    {
        public int i;
        public BaseClass() {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int param cons");
                this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            //i=10 //base class members should only be initialized in the base class itself
            j = 20;

        }
        public DerivedClass(int i,int j):base(i)
        {
            //call a specific constructor of the base class
            //if not specified,it calls the no parameter constructor of the base class.
            Console.WriteLine("derived class int ,int cons");
            //this.i=i;
            this.j = j;
            

        }
    }
}