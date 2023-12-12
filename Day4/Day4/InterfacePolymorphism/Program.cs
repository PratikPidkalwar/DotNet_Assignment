
//o and o2 both referaces are poiting to the 



namespace InterfacePolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Class1 o = new Class1();
            Class2 o2 = new Class2();
          
            //method 1

            o.Insert();
            o2.Insert();
           //similar name method call having main formm 



            //method 2

            IdbFunctions oIdb;
            oIdb = o;
            oIdb.Insert();

            oIdb = o2;
            oIdb.Insert();




        }
    }

    public interface IdbFunctions
    {
        void Insert();
       
    }


    public class Class1 : IdbFunctions
    {
       

        public void Insert()
        {
            Console.WriteLine("Insert");
        }

      
    }
    public class Class2 : IdbFunctions
    {


        public void Insert()
        {
            Console.WriteLine("Insert");
        }


    }
}