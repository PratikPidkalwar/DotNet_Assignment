
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ServerPractice
{
    internal class Program
    {
        static void Main()
        {
            //Connection();
           // Insert();
           Employees e= new Employees { EmpNo=7, Name="Baby",Basic=6000,DeptNo=10};
            // Insert1(e);
            InsertWithParameter(e);
        }
        static void Connection()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = Practice; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                sc.Open();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sc.Close();

            }
        }

        static void Insert()
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = Practice; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                sc.Open();
                SqlCommand cmd = sc.CreateCommand();
                cmd.Connection = sc;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values (5,'mom',6000,50)";
                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sc.Close();

            }

        }
        static void Insert1(Employees e)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = Practice; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sc;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"Insert into Employees values ({e.EmpNo},'{e.Name}',{e.Basic},{e.DeptNo})";
                cmd.ExecuteNonQuery ();
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sc.Close();
            }
        }

        static void InsertWithParameter(Employees e)
        {
            SqlConnection sc=new SqlConnection();
            sc.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = Practice; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sc;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values (@EmpNo,@Name,@Basic,@DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);
                cmd.Parameters.AddWithValue("@Name", e.Name);
                cmd.Parameters.AddWithValue("@Basic", e.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", e.DeptNo);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sc.Close();
            }
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