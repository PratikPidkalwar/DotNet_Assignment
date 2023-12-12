namespace AnonymousMethodsAndLambdas
{
    internal class Program
    {
        static void Main1()
        {
            int i = 100;
            Action o1 = delegate()
            {
                //anon method allows you to access local variables
                //       declared in the calling code(outside function)
                Console.WriteLine(i);
                Console.WriteLine("anon method called");
            };
            o1();

            Func<int, int, int> o2 = delegate(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(o2(10,5));


            Predicate<Employee> o3 = delegate (Employee obj)
            {
                if (obj.Basic > 10000)
                    return true;
                else
                    return false;
            };
            Employee e = new Employee { EmpNo = 1, Name = "a", Basic = 1200 };
            Console.WriteLine(o3(e));


        }

       
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}

namespace AnonymousMethodsAndLambdas2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(GetDouble(10));
            
            Func<int, int> o1 = GetDouble;
            Console.WriteLine(o1(10));

            Func<int, int> o2 = delegate(int a)
            {
                return a * 2;
            };
            Console.WriteLine(o2(10));

            //Func<int, int> o3 = (a) => a * 2;
            Func<int, int> o3 = a => a * 2;

            Console.WriteLine(o3(10));

            Func<string> o4 = ()=> DateTime.Now.ToLongTimeString();
            Console.WriteLine(o4());

            Func<int,int,int> o5= (a,b) => a + b;
            Console.WriteLine(o5(10,5));

            Func<int,bool> o6 = a => a%2 == 0;
            Console.WriteLine(o6(10));

            Predicate<Employee> o7 = obj => obj.Basic > 10000;
            Employee e = new Employee { EmpNo = 1, Name = "a", Basic = 1200 };
            Console.WriteLine(o7(e));

            Action o8 = () => { Console.WriteLine("void ret val funcs"); };
            Action o9 = () =>  Console.WriteLine("void ret val funcs"); 
            o8();
            o9();
        }

        static int GetDouble(int a)
        {
            return a * 2;
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}