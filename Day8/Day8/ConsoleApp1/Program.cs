namespace ConsoleApp1
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            try
            {
                Class1 obj = new Class1();
                // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }
        }
        static void Main2(string[] args)
        {
            try
            {
                Class1 obj = new Class1();
                // obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occured");
            }
            Console.WriteLine("after catch");
        }
        static void Main(string[] args)
        {
            try
            {
                Class1 obj = new Class1();
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch(NullReferenceException ex)  
            {
                Console.WriteLine(ex);

            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("after finally");
        }

    }

    public class Class1
    {
        int p1;
        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }

    }
}