using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace comp.App_Code
{
    public class StudentCrud
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public StudentCrud()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public DataTable GetAllStudent()
        {

            DataTable tb = new DataTable();
            string qry = "select * from student";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                tb.Load(dr);
            }
            con.Close();
            return tb;

        }
        public Student GetStudentById(int id)
        {
            Student stu = new Student();
            string qry = "select * from student where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    stu.Id = Convert.ToInt32(dr["id"]);
                    stu.Name = dr["Name"].ToString();
                    stu.Dob = dr["DOB"].ToString();
                    stu.Sex = dr["sex"].ToString();
                    stu.Phone = dr["phone"].ToString();
                    stu.Address = dr["address"].ToString();
                }
            }
            con.Close();
            return stu;
        }
        public int AddStudent(Student stu)
        {
            int result = 0;
            string qry = "insert into student values(@id,@name,@dob,@sex,@phone,@address)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", stu.Name);
            cmd.Parameters.AddWithValue("@id", stu.Id);
            cmd.Parameters.AddWithValue("@dob", stu.Dob);
            cmd.Parameters.AddWithValue("@sex", stu.Sex);
            cmd.Parameters.AddWithValue("@phone", stu.Phone);
            cmd.Parameters.AddWithValue("@address", stu.Address);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public int UpdateStudent(Student stu)
        {
            int result = 0;
            string qry = "update student set Name=@name,Dob=@dob,sex=@sex,phone=@phone,address=@address  where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", stu.Id);
            cmd.Parameters.AddWithValue("@name", stu.Name);
            cmd.Parameters.AddWithValue("@dob", stu.Dob);
            cmd.Parameters.AddWithValue("@sex", stu.Sex);
            cmd.Parameters.AddWithValue("@phone", stu.Phone);
            cmd.Parameters.AddWithValue("@address", stu.Address);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DeleteStudent(int id)
        {
            int result = 0;
            string qry = "delete from student where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}