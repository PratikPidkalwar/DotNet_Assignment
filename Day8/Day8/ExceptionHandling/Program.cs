namespace ExceptionHandling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            o = null;
            int x = Convert.ToInt32(Console.ReadLine());
            o.P1 = 100 / x;
            Console.WriteLine(o.P1);
           // Console.WriteLine("no Exception");

        }
        static void Main2(string[] args)
        {
            Class1 o = new Class1();
            try 
            {
                o = null;
                int x = Convert.ToInt32(Console.ReadLine());
                o.P1 = 100 / x;
                Console.WriteLine(o.P1);
                 Console.WriteLine("no Exception");

            }
            catch{
                Console.WriteLine("Exception Occured");        
            }
        }
        static void Main3(string[] args)
        {
            Class1 o = new Class1();
            try
            {
               // o = null;
                int x = Convert.ToInt32(Console.ReadLine());
                o.P1 = 100 / x;
                Console.WriteLine(o.P1);
                Console.WriteLine("no Exception");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBException Occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRException Occured");
            }
            catch (FormatException)
            {
                Console.WriteLine("FRException Occured");
            }
           
        }
        static void Main4(string[] args)
        {
            Class1 o = new Class1();
            try
            {
                // o = null;
                int x = Convert.ToInt32(Console.ReadLine());
                o.P1 = 100 / x;
                Console.WriteLine(o.P1);
                Console.WriteLine("no Exception");

            }
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("DBException Occured");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("NRException Occured");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("FRException Occured");
            //}
            catch (SystemException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //Base class exception has to caught after derived class aexception
            }
        }
        static void Main5(string[] args)
        {
            Class1 o = new Class1();
            try
            {
                // o = null;
                int x = Convert.ToInt32(Console.ReadLine());
                o.P1 = 100 / x;
                Console.WriteLine(o.P1);
                Console.WriteLine("no Exception");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBException Occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRException Occured");
            }
            catch (FormatException)
            {
                Console.WriteLine("FRException Occured");
            }
            //catch (SystemException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message); //Base class exception has to caught after derived class aexception
            //}
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("after finally");
        }
        static void Main6()// nested try block
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("outer finally");

            }
            Console.ReadLine();
        }
    }
    public class Class1
    {
        private int p1;

        public int P1
        {
            get { return p1; }
            set { p1 = value; }
        }

    }
}


namespace ExceptionHandling2
{
    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("FormatException occurred");
            //}
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }

            catch (InvalidP1Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ApplicationException ex) //all user defined exceptions that have not been handled before
            {
                Console.WriteLine(ex.Message);
            }
            catch (SystemException ex) //all .net exceptions that have not been handled before
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }

    public class Class1
    {
        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //dont do this
                    //Console.WriteLine("invalid P1"  );

                    //throw an object of the Exception class or any of its derived classes
                    //Exception ex = new Exception();
                    //Exception ex = new Exception("Invalid P1");
                    //throw ex;
                    //throw new Exception("Invalid P1");

                    //throw new InvalidP1Exception();
                    throw new InvalidP1Exception("Invalid P1");

                }
            }
        }
    }

    public class InvalidP1Exception : ApplicationException
    {
        public InvalidP1Exception(string message) : base(message)
        {

        }
    }
}

