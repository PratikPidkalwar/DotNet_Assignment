using Microsoft.Data.SqlClient;
using System.Data;

namespace ModelBinding.Models
{
    internal class Employee
    {
        internal object Basic;

        public object EmpNo { get; internal set; }
        public object Name { get; internal set; }
        public object DeptNo { get; internal set; }

        static void Insert()
        {
            SqlConnection sc = new SqlConnection();
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
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sc.Close();
            }
        }

        static void UpdateData(Employee obj)
        {
            SqlConnection sc = new SqlConnection();
            sc.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                sc.Open();
                SqlCommand UpData = new SqlCommand();
                UpData.Connection = sc;
                UpData.CommandType = CommandType.StoredProcedure;
                UpData.CommandText = "UpdateData";

                UpData.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                UpData.Parameters.AddWithValue("@Name", obj.Name);
                UpData.Parameters.AddWithValue("@Basic", obj.Basic);
                UpData.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                UpData.ExecuteNonQuery();
                Console.WriteLine("Update Data");
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

        public static void DeleteData(int id)
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

                DeleteData.Parameters.AddWithValue("@EmpNo", id);

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

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = new List<Employee>();
            //
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employee obj = new Employee();
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");
                    lstEmps.Add(obj);

                    //lstEmps.Add(new Employee { EmpNo = dr.GetInt32("EmpNo") })
                }
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            //
            return lstEmps;
        }



        public static Employee GetSingleEmployees(int EmpNo)
        {
            Employee obj = new Employee();
            //
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exam;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();
                //dr.HasRows
                if (dr.Read())
                {
                    obj.EmpNo = dr.GetInt32("EmpNo");
                    obj.Name = dr.GetString("Name");
                    obj.Basic = dr.GetDecimal("Basic");
                    obj.DeptNo = dr.GetInt32("DeptNo");

                }
                else
                    obj = null;
                dr.Close();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            //
            return obj;
        }
    }
}
