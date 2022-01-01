using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ADOCRUD.Models
{
    public class SqlDbHelper
    {
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            string connectionString = "data source= DINESH-PC; database = Demodb1; integrated security =true;";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Student", con);

            SqlDataReader reader =cmd.ExecuteReader();

            while (reader.Read())
            {
                Student s = new Student();
                s.RollNumber = (int)reader["RollNumber"];
                s.Name = reader["Name"].ToString();
                s.Age = (int)reader["Age"];
                s.Email = reader["Email"].ToString();
                s.DateOfBirth = (DateTime)reader["DateOfBirth"];

                students.Add(s);
            }

            con.Close();
            return students;
        }

        public Student GetStudentByRN (int RN)
        {
            Student student = new Student();

            string connectionString = "data source = Dinesh Patil PC";
            
        }

        public bool InsertStudent(Student student, out int studentRollNumber)
        {
            try
            {
                List<Student> students = new List<Student>();

                string connectionString = "data source= DINESH-PC; database =Demodb1; integrated security = true;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmd = new SqlCommand("usp_InsertStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Age", student.Age);
                cmd.Parameters.AddWithValue("@Email", student.Email);
                cmd.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);

                SqlParameter rollNumber = new SqlParameter();
                rollNumber.ParameterName = "@RollNumber";
                rollNumber.SqlDbType = SqlDbType.Int;
                rollNumber.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(rollNumber);

                cmd.ExecuteNonQuery();
                con.Close();

                studentRollNumber = (int)rollNumber.Value;

                return true;
            }
            catch(Exception ex)
            {
                studentRollNumber = 00;
                return false;
            }

        } 

    }
}