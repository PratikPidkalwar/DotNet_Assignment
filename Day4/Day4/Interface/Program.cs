namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");
           Class1 o = new Class1();
            o.Display();
            //method 1
            o.Insert();
            o.Delete();
            o.Update();

            //method 2
            IdbFunctions oIdb;
            oIdb = o;
            oIdb.Insert();
            oIdb.Delete();
            oIdb.Update();

            //method 3
            ((IdbFunctions)o).Insert(); //typeCasting


            //method 4
            (o as  IdbFunctions).Insert(); //typeCasting
        }
    }

    public interface IdbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }


    public class Class1 : IdbFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Display()
        {
            Console.WriteLine("Display");
        }

        public void Insert()
        {
            Console.WriteLine("Insert");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }
    }
}