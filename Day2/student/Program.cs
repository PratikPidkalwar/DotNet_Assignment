/*Create a class Student with the following specifications

Properties
string Name - Max 50 chars
int RollNo - must be > 0
decimal Subject1Marks - 0-100
decimal Subject2Marks - 0-100
decimal Subject3Marks - 0-100


Methods
decimal CalculatePercentage() -returns calculated percentage

Constructors
constructors to accept 5,4,3,2,1,0 parameters for properties 
*/







namespace student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Student s = new Student("Pidkalwar",62,99,50,99);
           
            /*Student s3 = new Student("bappa");
                       Student s4 = new Student();*/
            Console.WriteLine(s.CalculatePercentage()+"%");
        }
    }

    public class Student
    {
        public Student(string name="unknown", int rollno=1, decimal subject1mark = 10, decimal subject2mark =10, decimal subject3mark = 10)
        {
            Name=name;
            RollNo=rollno;
            Subject1Marks=subject1mark;
            Subject2Marks=subject2mark;
            Subject3Marks=subject3mark;
        }
        private string name;

        public string Name
        {
            set
            {
                if (value.Length <= 50 && value.Length>=0)
                    value = name;
                else Console.WriteLine("Not valid");
            }
            get
            {
                return name;
            }
        }
        private int rollno;

        public int RollNo
        {
            set
            {
                if (value > 0)
                {
                    rollno = value;
                }
                else
                {
                    // Console.WriteLine("value should be greater than 0");
                    Console.WriteLine("You Write rollno is: " + value + ". Value should be greater than 0");
                }
            }
            get
            {
                return rollno;
            }
        }
        private decimal subject1marks;

        public decimal Subject1Marks
        {
            set
            {
                if (value > 0 && value<100)
                {
                    subject1marks = value;
                }
                else
                {
                    // Console.WriteLine("value should be greater than 0");
                    Console.WriteLine("You Write subject1marks is: " + value + ". Value should be greater than 0");
                }
            }
            get
            {
                return subject1marks;
            }
        }
        private decimal subject2marks;

        public decimal Subject2Marks
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    subject2marks = value;
                }
                else
                {
                    // Console.WriteLine("value should be greater than 0");
                    Console.WriteLine("You Write subject2marks is: " + value + ". Value should be greater than 0");
                }
            }
            get
            {
                return subject2marks;
            }
        }
        private decimal subject3marks;

        public decimal Subject3Marks
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    subject3marks = value;
                }
                else
                {
                    // Console.WriteLine("value should be greater than 0");
                    Console.WriteLine("You Write subject3marks is: " + value + ". Value should be greater than 0");
                }
            }
            get
            {
                return subject3marks;
            }
        }
       public decimal CalculatePercentage()
        {
            decimal total = subject1marks + subject2marks + subject3marks;
            decimal perc = (total / 300) * 100;
            return perc;
        }

    }
}