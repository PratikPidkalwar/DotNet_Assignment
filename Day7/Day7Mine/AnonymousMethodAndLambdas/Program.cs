namespace AnonymousMethodAndLambdas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Action o1 = delegate ()
        {
            Console.WriteLine("Ananymous Method Call");
        };
            o1();


            //Anonymous 
            Func<int, int, int> o2 = delegate (int x, int y)
            {
                return x + y;
            };
            Console.WriteLine(o2(12, 12));

            Func<string> o3 = delegate ()
            {
                return DateTime.Now.ToLongTimeString();

            };
            Console.WriteLine(o3());

            Func<int, int> o4 = delegate (int a)
        {
            return a * 2;
        };
            Console.WriteLine(o4(12));

            Predicate<int> o5 = delegate (int a)
            {
                if (a % 2 == 0)
                    return true;
                else return false;
            };
            Console.WriteLine(o5(11));

            Predicate<Employee> o6 = delegate (Employee obj)
            {
                if (obj.Basic > 10000)
                    return true;
                else
                    return false;
            };
            Employee e = new Employee { EmpNo = 1, Name = "Pratik", Basic = 12000 };
            Console.WriteLine(o6(e));



 //----------------------------------------------------------------------------------------------------------------------


            //Lambda use =>                            
            // Func<int, int> o7 = (a) => a * 2;
            Func<int, int> o7 = a => a * 2;
            Console.WriteLine(o7(10));

            Func<int, int, int> o8 =  ( x,  y) => x + y;
            
            Console.WriteLine(o8(120, 120));

            Func<string> o9 = () => DateTime.Now.ToLongTimeString();
        
            Console.WriteLine(o9());

            Func<int, int> o10 = a=> a * 2;
           
            Console.WriteLine(o10(100));

            //Predicate<int> o11 = (a)=>
            //{
            //    if (a % 2 == 0)
            //        return true;
            //    else return false;
            //};
            //Console.WriteLine(o11(6));

            Predicate<int> o11=a=> a % 2 == 0;

            //Predicate<Employee> o12 = (obj)=>
            //{
            //    if (obj.Basic > 10000)
            //        return true;
            //    else
            //        return false;
            //};
            Predicate<Employee> o12 = obj => obj.Basic > 10000;
            Employee ee = new Employee { EmpNo = 1, Name = "Pratik", Basic = 12000 };
            Console.WriteLine(o12(ee));

            Action o13 = () => { Console.WriteLine("void return val function"); };
            Action o14 = () => Console.WriteLine("void return val function");

            o13();
            o14();

//----------------------------------------------------------------------------------------------------------------------


            // Expression bodied members


        }





    }
    public class Employee
    {
        public string? Name { set; get; }
        public int EmpNo { set; get; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }
    }
}