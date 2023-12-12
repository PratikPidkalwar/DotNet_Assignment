using System.Collections;

namespace AssignEmpList
{
    internal class Program
    {
       static List<Employee> objList = new List<Employee>();
   
        static void AddData()
        {
            objList.Add(new Employee() { Name = "ABC", EmpNo = 1, Gender = "Male", Salary = 50000 });
            objList.Add(new Employee() { Name = "CYZ", EmpNo = 2, Gender = "Male", Salary = 52000 });
            objList.Add(new Employee() { Name = "SAd", EmpNo = 3, Gender = "Male", Salary = 50000 });
            objList.Add(new Employee() { Name = "sdsda", EmpNo = 4, Gender = "Male", Salary = 50000 });
            objList.Add(new Employee() { Name = "asdasdas", EmpNo = 5, Gender = "Male", Salary = 50000 });

        }
        
        static void Main()
        {
            Directory.CreateDirectory("C:\\EMPDATA");

            AddData();

            setData(objList);
           

            Console.WriteLine("THank you for adding Data ");

            getData(objList);



        }
        static void setData(List<Employee> employees)
        {
           StreamWriter writer = File.CreateText("C:\\EMPDATA\\emp.txt");
          
            foreach(Employee employee in employees)
            {
                writer.WriteLine(employee.Name);
                writer.WriteLine(employee.EmpNo);
                writer.WriteLine(employee.Salary);
                writer.WriteLine(employee.Gender);
            }   
            writer.Close();
        }
        static void getData(List<Employee> employees)
        {
            string s;
            StreamReader reader = File.OpenText("C:\\EMPDATA\\emp.txt");
            Console.WriteLine("Starting Reading file >>");
            Thread.Sleep(2500);
            foreach (Employee employee in employees)
            {
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
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

        public Employee(string name = default, int empno = 1, int salary = 35000, string gender=default)
        {
            Name = name;
            EmpNo = empno;
            Salary = salary;
            Gender = gender;

        }

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
                if (value != "")
                {
                    name = value;
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
                    salary = value;
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