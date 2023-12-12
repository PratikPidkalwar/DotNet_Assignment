using System.Collections;
using System.Runtime.CompilerServices;

namespace dalegate1
{
    internal class Program
    {

        static void Main()
        {
            try
            {
                Employee e = new Employee();
                e.InvalidId += E_InvalidId;
                e.Id = 9;

                e.empDisplayDetails();
            }
            catch
            {
                
            }
            
        }

        private static void E_InvalidId()
        {
           Console.WriteLine("Your Id is Event is Raised ");
        }
    }

    public delegate void InvalidEmpId();

    public class Employee
    {
        private int id; 
        private string name;


        public event InvalidEmpId InvalidId;
        public int Id
        {
            get { return id; }
            set
            {
                if(value > 10)
                {
                    id  = value;
                }
                else
                {
                    //Raise the event
                    InvalidId();
                }
            }
        }

        public Employee()
        {

        }
        public Employee(int id = 1)
        {
            this.Id = id;
        }

        public void empDisplayDetails()
        {
            Console.WriteLine("Employee Id is "+Id);
        }

    }
       
 }
    
