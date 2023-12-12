namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Class1 c1 = new Class1();
            c1.Display();
            c1.Insert();
            c1.Update();

        }
    }
    public interface IFile
    {
        void Insert();
        void Update();
        void Delete();

    }
    public interface IDbFunction
    public class Class1:IFile
    {
        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Display()
        {
            Console.WriteLine("Display it.");
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