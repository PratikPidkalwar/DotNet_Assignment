namespace AssignEmpObject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            setData();
            getData();

        }
        static void setData()
        {
            Directory.CreateDirectory(@"c:\\EmployeeDirectory");

            Employee emp = new Employee();
            emp.Name = "pratik";
            emp.EmpNo = 1;
            emp.Salary = 10000;
            emp.Gender = "M";

            StreamWriter writer = File.CreateText("c:\\EmployeeDirectory\\EmployeeFile.txt");
            writer.WriteLine(emp.EmpNo);
            writer.WriteLine(emp.Name);
            writer.WriteLine(emp.Salary);
            writer.WriteLine(emp.Gender);

            writer.Close();
        }
        static void getData()
        {
            string s;
            StreamReader reader = File.OpenText("c:\\EmployeeDirectory\\EmployeeFile.txt");
            Console.WriteLine("Starting Reading File >> ");
            Thread.Sleep(2500);
            while ((s = reader.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }

            reader.Close();



        }
    }
    public class Employee
    {
        string name;
        int empno;
        int salary;
        string gender;

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
                    Console.WriteLine("please enter empno greater than 0");
                }
            }
            get { return empno; }
        }
        public string Name
        {
            set
            {
                if(value != "") {
                     name= value ;
                }
                else
                {
                    Console.WriteLine("please enter Name");
                }
            }
            get { return name; }
        }
        public int Salary
        {
            set
            {
                if (value > 0)
                {
                    salary= value;
                }
                else
                {
                    Console.WriteLine("please enter salary greater than 0");
                }
            }
            get { return salary; }
        }
        public string Gender
        {
            set
            {
                if (value != "")
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("please enter gender");
                }
            }
            get { return gender; }
        }
    }

}