namespace Assignment_Employess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            Employee e1 = new Employee("pratik",1,2000,10);
            Console.WriteLine(e1.GetNetSalary());
          //    Employee e2 = new Employee("Sudip", 2, 2550);

        }
    }

    public class Employee
    {
        public Employee(string namee="unknown", int id=1, decimal basicSal=101, short deptno=1)
        {
             EmpNo= id;
            Name = namee;
             Basic= basicSal;
             DeptNo= deptno;
        }
       private string name;

        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
               
                else
                    Console.WriteLine("name should be required");
            }
            get
            {
                return name;
            }
        }
        private int empno;

        public int EmpNo
        {
            set
            {
                if (value > 0)
                {
                    empno = value;
                }
                else
                {
                   // Console.WriteLine("value should be greater than 0");
                    Console.WriteLine("You Write EmpNo is: "+value+ ". Value should be greater than 0");
                }
            }
            get
            {
                return empno;
            }
        }
        private decimal basic;

        public decimal Basic
        {
            set
            {
                if(value > 100 && value < 500000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("basic should more than 100 and less than 500000");
                }
            }
            get { return basic; }
        }
        private short deptno;
        public short DeptNo{
            set
            {
                if(value > 0) deptno = value;
                else Console.WriteLine("DeptNo should be greater than 0");
            }
            get { return deptno; }
        }
        public decimal GetNetSalary()
        {
            int deduction = 1000;
            decimal basicSalary = basic;
            decimal netSalary = basicSalary - deduction;
            return netSalary;
        }

    }
   
}
