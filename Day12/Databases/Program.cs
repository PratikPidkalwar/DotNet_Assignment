
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Data;

namespace DataBases
{
    internal class Program
    {
        static void Main()
        {
            Connection();
            // Insert();
            //  Employees e =  new Employees { EmpNo = 103, Name = "Yogesh", Basic = 2456, DeptNo = 3 };
            //Insert1(e);

            // Employees e = new Employees { EmpNo = 105, Name = "Madan", Basic = 250000, DeptNo = 5 };
            // UpdateWithStoreProcudure(e);
            //InsertWithParameter(e);
            // InsertWithStoreProcudure(e);

             Employees e = new Employees { EmpNo = 105};

           // DeleteWithStoreProcudure(e);

            // SingleValue();
            //DataReader();
            // DataNextReader();
        }
        static void Connection()
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ycpoct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                cn.Open();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Insert()
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values(102,'Suraj',10000,2)";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Insert1(Employees e)
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"insert into Employees values ({e.EmpNo},'{e.Name}',{e.Basic},{e.DeptNo})";
                cmd.ExecuteNonQuery();
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void InsertWithParameter(Employees e)
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
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
                cn.Close();
            }
        }

        static void InsertWithStoreProcudure(Employees e)
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";
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
                cn.Close();
            }
        }

        static void UpdateWithStoreProcudure(Employees e)
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "UpdateDataWithStProcedeure";
               // cmd.CommandText = "Update Employee set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
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
                cn.Close();
            }
        }

        static void DeleteWithStoreProcudure(Employees e)
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "DeleteDataWithStoreProcedeure";
                // cmd.CommandText = "Update Employee set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", e.EmpNo);
               
                cmd.ExecuteNonQuery();
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void SingleValue()
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select Name from Employees where EmpNo = 101";
               // cmd.CommandText = "select count(*) from Employees";
               // cmd.CommandText = "select * from Employees";

                object retval=cmd.ExecuteScalar();
                Console.WriteLine(retval);
                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void DataReader()
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                 cmd.CommandText = "select * from Employees";
               

               SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr["EmpNo"]);


                    Employees obj = new Employees();
                    obj.EmpNo = (int)dr[0];
                    obj.EmpNo = (int)dr["EmpNo"];

                    obj.EmpNo = dr.GetInt32(0);
                    obj.EmpNo = dr.GetInt32("EmpNo");
                }
                dr.Close();

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void DataNextReader()
        {
            SqlConnection cn = new SqlConnection();
            //  Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            //cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Ycpoct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees;select * from Departments";


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr["EmpNo"]);


                    Employees obj = new Employees();
                    obj.EmpNo = (int)dr[0];
                    obj.EmpNo = (int)dr["EmpNo"];

                    obj.EmpNo = dr.GetInt32(0);
                    obj.EmpNo = dr.GetInt32("EmpNo");
                }
                dr.NextResult();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr["DeptNo"]);

                    Console.WriteLine(dr.GetInt32(0));
                    Console.WriteLine(dr.GetInt32("EmpNo"));
                   
                }
                dr.Close();

                Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
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
    