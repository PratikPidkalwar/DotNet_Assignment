namespace EmployeeExample
{
    internal class Program
    {
        static void Main()
        {
            Employee e1= new Employee("Pratik",50000,10);
            e1.Display();
            Employee e2 = new Employee("sudip", 50000, 10);
            e2.Display();
            Employee e3 = new Employee("Lalit", 50000, 10);
            e3.Display();

            
            e1.Display();
            
            e2.Display();
           
            e3.Display();
        }
    }
    public class Employee
    {

        string name; //-> no blank names should be allowed
        static int counter = 0;
        int empNo; //-> must be greater than 0
        decimal basic;// -> must be between some range
        short deptNo;// -> must be > 0

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("Invalid Name");
            }
        }
        //public int EmpNo
        //{
        //    get { return empNo; }
        //    set
        //    {
        //        if (value > 0)
        //            empNo = value;
        //        else
        //            Console.WriteLine("Invalid EmpNo");
        //    }
        //}
        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value < 10000 || value > 100000)
                    Console.WriteLine("Invalid Basic");
                else
                    basic = value;

            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Invalid EmpNo");
            }
        }
        public decimal GetNetSalary()
        {
            return Basic * 2;
        }

        public void Display()
        {
            Console.WriteLine("Empno"+empNo);
            Console.WriteLine("name" + name);
            Console.WriteLine("basic" + basic);
            Console.WriteLine("deptno" + deptNo);
            Console.WriteLine("netSalary" + GetNetSalary());

        }
        public Employee(string Name = "default", decimal Basic = 10000, short DeptNo = 1)
        {
            counter += 1;
            empNo = counter;  //property - set
            //this.empNo = EmpNo; //variable -- do not use this --- validations are not called
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }
    }
}