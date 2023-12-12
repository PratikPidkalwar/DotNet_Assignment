using Microsoft.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace ExamDayBefore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            /*  CreateConnection();
              Insert();*/
            //  Employees e = new Employees {EmpNo=7};
            // InsertwithParameter(e);
            // InsertStoreProcedure(e);

            // UpdateData(e);
            //DeleteData(e);
            // SingleValue();
            // DataReader();
            // Transaction1();

            //TransactionExample();

            //List<Employees> lstobj = GetEmployeeeDetails();
            //foreach (Employees employee in lstobj)
            //{
            //    Console.WriteLine(employee.EmpNo);
            //    Console.WriteLine(employee.Name);
            //   Console.WriteLine(employee.Basic);
            //    Console.WriteLine(employee.DeptNo);
            //    Thread.Sleep(1500);

            //}

















            List<Employees> lstobj = ListEmployees();
            foreach (Employees e in lstobj)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(e.EmpNo);
                Console.WriteLine(e.Basic);
                Console.WriteLine(e.DeptNo);

            }



        }
        static void CreateConnection()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                Console.WriteLine("Connected");
            }
            catch(Exception ex)
            {
                throw;
            }
            finally { 
                
                sc.Close();
            
            }
        }
        static void Insert()
        {
            SqlConnection sc= new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand InsertCmd = new SqlCommand();  
                InsertCmd.Connection = sc;
                InsertCmd.CommandType = CommandType.Text;
                InsertCmd.CommandText = "insert into employees values (3,'vishu',100000,3)";

                InsertCmd.ExecuteNonQuery();
                Console.WriteLine("Data inserted");
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                sc.Close();
            }
        }
        static void InsertwithParameter(Employees e)
        {
            SqlConnection sc= new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                sc.Open();
                SqlCommand InsertCmd = new SqlCommand();
                InsertCmd.Connection = sc;
                InsertCmd.CommandType = CommandType.Text;
                InsertCmd.CommandText = "insert into Employees values (@EmpNo,@Name,@Basic,@DeptNo)";
                InsertCmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);
                InsertCmd.Parameters.AddWithValue("@Name", e.Name);
                InsertCmd.Parameters.AddWithValue("@Basic", e.Basic);
                InsertCmd.Parameters.AddWithValue("@DeptNo", e.DeptNo);
                InsertCmd.ExecuteNonQuery();
                Console.WriteLine("Insert data");

            }
            catch( Exception ex)
            {
                throw;
            }
            finally
            {
                sc.Close();
            }
        }
        static void InsertStoreProcedure(Employees e)
        {
            SqlConnection sc= new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand InsertCmd = new SqlCommand();
                InsertCmd.Connection = sc;
                InsertCmd.CommandType = CommandType.StoredProcedure;
                InsertCmd.CommandText = "InsertEmployee";

                InsertCmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);
                InsertCmd.Parameters.AddWithValue("@Name", e.Name);
                InsertCmd.Parameters.AddWithValue("@Basic", e.Basic);
                InsertCmd.Parameters.AddWithValue("@DeptNo", e.DeptNo);
                InsertCmd.ExecuteNonQuery();
                Console.WriteLine("Insert Data");
            }
            catch ( Exception ex )
            {
                throw;
            }
            finally 
            { 
                sc.Close(); 
            }
        }
        static void UpdateData(Employees e)
        {
            SqlConnection sc=new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand UpData = new SqlCommand();
                UpData.Connection = sc;
                UpData.CommandType = CommandType.StoredProcedure;
                UpData.CommandText = "UpdateData";

                UpData.Parameters.AddWithValue("@EmpNo", e.EmpNo);
                UpData.Parameters.AddWithValue("@Name", e.Name);
                UpData.Parameters.AddWithValue("@Basic", e.Basic);
                UpData.Parameters.AddWithValue("@DeptNo", e.DeptNo);
                UpData.ExecuteNonQuery();
                Console.WriteLine("Update Data");
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                sc.Close();
            }
        }

        static void DeleteData(Employees e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand DeleteData = new SqlCommand();
                DeleteData.Connection = sc;
                DeleteData.CommandType = CommandType.StoredProcedure;
                DeleteData.CommandText = "DeleteData";

                DeleteData.Parameters.AddWithValue("@EmpNo", e.EmpNo);
                //DeleteData.Parameters.AddWithValue("@Name", e.Name);
                //DeleteData.Parameters.AddWithValue("@Basic", e.Basic);
                //DeleteData.Parameters.AddWithValue("@DeptNo", e.DeptNo);
                DeleteData.ExecuteNonQuery();
                Console.WriteLine("Delte Data");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sc.Close();
            }
        }

        static void SingleValue()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand SingleValue = new SqlCommand();
                SingleValue.Connection = sc;
                SingleValue.CommandType = CommandType.Text;
                // SingleValue.CommandText = "select Name from employees where EmpNo=1 ";
                // SingleValue.CommandText = "select * from employees where EmpNo > 3 ";
                SingleValue.CommandText = "select count(*) from employees";


                Object retval = SingleValue.ExecuteScalar();
                Console.WriteLine(retval);
                Console.WriteLine("Success");
            }
            catch(Exception ex)
            {
                throw;
            }
            finally { sc.Close(); }
        }

        static void DataReader()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand DataReader = new SqlCommand();
                DataReader.Connection = sc;
                DataReader.CommandType = CommandType.Text;
                DataReader.CommandText = "select * from Employees;select * from Departments";

                SqlDataReader dr = DataReader.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["EmpNo"]+" ");
                    Console.WriteLine(dr["Name"]+" ");
                    Console.WriteLine(dr["Basic"]+" ");
                    Console.WriteLine(dr["DeptNo"]+" ");
                }
                dr.NextResult();
                while (dr.Read())
                {
                    Console.WriteLine(dr["DeptNo"]);
                    Console.WriteLine(dr["Name"]);
                }
                dr.Close();
                Console.WriteLine("Success");
            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                sc.Close();
            }
        }
        static void TransactionExample()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            cn.Open();
           SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.Transaction = t;

            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "Insert into Employees values(12,'Pratik',52000,3)";

            SqlCommand cmdInsert2 = new SqlCommand();
            cmdInsert2.Connection = cn;
            cmdInsert2.Transaction = t;
            
            cmdInsert2.CommandType = System.Data.CommandType.Text;
           cmdInsert2.CommandText = "Insert into Employees values(13,'Pratik',52000,3)";

            try
            {
                cmdInsert.ExecuteNonQuery();
                cmdInsert2.ExecuteNonQuery();

                t.Commit();
                Console.WriteLine("Successfully Commiteed new Records ");
            }catch(Exception ex)
            {
                t.Rollback();
                throw ;
            }
            finally
            {
                cn.Close();
            }



        }
        static void Transaction1()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            cn.Open();
            SqlTransaction t = cn.BeginTransaction();
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = t;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Employees values(10,'Prakash',10000,7)";

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = cn;
            cmd1.Transaction = t;

            cmd1.CommandType= CommandType.Text;
            cmd1.CommandText= "Insert into Employees values(11,'Rita',20000,7)";
            try
            {
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                t.Commit();
                Console.WriteLine("success");

            }
            catch(Exception ex)
            {
                t.Rollback();
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        static List<Employees> GetEmployeeeDetails()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            List<Employees> lst = new List<Employees>();
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Select *From Employees";

                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    Employees obj = new Employees();
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");

                    lst.Add(obj);
                }

            }catch(Exception ex)
            {
                throw;
            }finally { cn.Close(); }


            return lst;
        }

        static List<Employees> ListEmployees()
        {
           SqlConnection cn= new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
             
            List<Employees> ls= new List<Employees>();
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Employees obj = new Employees();
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");

                    ls.Add(obj);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            finally { cn.Close(); }


            return ls;
        }

    }
    public class Employees
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }

        public int DeptNo { get; set; }
    }
}