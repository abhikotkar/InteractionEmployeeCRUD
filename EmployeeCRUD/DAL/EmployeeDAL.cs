using EmployeeCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCRUD.DAL
{
    public class EmployeeDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public EmployeeDAL()
        {
            con = new SqlConnection(Startup.ConnectionString);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> elist = new List<Employee>();
            string qry = "select * from Employee";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employee e = new Employee();
                    e.Id = Convert.ToInt32(dr["Id"]);
                    e.Fname = dr["Fname"].ToString();
                    e.Mname = dr["Mname"].ToString();
                    e.Lname = dr["Lname"].ToString();
                    e.Gender = dr["Gender"].ToString();
                    e.DOB = dr["DOB"].ToString();
                    e.Address = dr["Address"].ToString();
                    e.City = dr["City"].ToString();
                    e.Pincode = dr["Pincode"].ToString();
                    e.Mobile = dr["Mobile"].ToString();
                    elist.Add(e);
                }
            }
            con.Close();
            return elist;
        }
        public Employee GetEmployeeById(int id)
        {
            Employee e = new Employee();
            string qry = "select * from Employee where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    e.Id = Convert.ToInt32(dr["Id"]);
                    e.Fname = dr["Fname"].ToString();
                    e.Mname = dr["Mname"].ToString();
                    e.Lname = dr["Lname"].ToString();
                    e.Gender = dr["Gender"].ToString();
                    e.DOB = dr["DOB"].ToString();
                    e.Address = dr["Address"].ToString();
                    e.City = dr["City"].ToString();
                    e.Pincode = dr["Pincode"].ToString();
                    e.Mobile = dr["Mobile"].ToString();
                }
            }
            con.Close();
            return e;
        }

        public int AddEmployee(Employee emp)
        {
            string qry = "insert into Employee values(@fname,@mname,@lname,@gender,@dob,@address,@city,@pincode,@mobile)";
            cmd = new SqlCommand(qry, con);

            cmd.Parameters.AddWithValue("@fname", emp.Fname);
            cmd.Parameters.AddWithValue("@mname", emp.Mname);
            cmd.Parameters.AddWithValue("@lname", emp.Lname);
            cmd.Parameters.AddWithValue("@gender", emp.Gender);
            cmd.Parameters.AddWithValue("@dob", emp.DOB);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@city", emp.City);
            cmd.Parameters.AddWithValue("@pincode", emp.Pincode);
            cmd.Parameters.AddWithValue("@mobile", emp.Mobile);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int UpdateEmployee(Employee emp)
        {
            string qry = "update Employee set Fname=@fname , Mname=@mname , Lname=@lname , Gender=@gender" +
                " ,DOB=@dob , Address=@address , City=@city" +
                " ,Pincode=@pincode , Mobile=@mobile where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.Parameters.AddWithValue("@fname", emp.Fname);
            cmd.Parameters.AddWithValue("@mname", emp.Mname);
            cmd.Parameters.AddWithValue("@lname", emp.Lname);
            cmd.Parameters.AddWithValue("@gender", emp.Gender);
            cmd.Parameters.AddWithValue("@dob", emp.DOB);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            cmd.Parameters.AddWithValue("@city", emp.City);
            cmd.Parameters.AddWithValue("@pincode", emp.Pincode);
            cmd.Parameters.AddWithValue("@mobile", emp.Mobile);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DeleteEmployee(int id)
        {
            string qry = "delete from Employee where Id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}
