using ADOCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOCRUD
{
    public partial class Student_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void loadStudents()
        {
            SqlDbHelper db = new SqlDbHelper();
            List<Student> students = db.GetAllStudents();

            gvStudents.DataSource = students;
            gvStudents.DataBind();
        }

        //Get called when we click on create button
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();

                student.Name = txtName.Text;
                student.Age = Convert.ToInt32(txtAge.Text);
                student.Email = txtEmail.Text;
                student.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

                SqlDbHelper db = new SqlDbHelper();
                int rollNumber;
                bool status = db.InsertStudent(student, out rollNumber);

                if (status)
                {
                    loadStudents();
                    lblMessage.Text = "Student inserted successfully. Student ROLLNUMBER is : " + rollNumber;
                }
                else
                {
                    lblMessage.Text = "Student insert failed";
                }
            }
            finally
            {
                clearFields();
            }
        }

        //Method to clear fields
        private void clearFields()
        {
            txtName.Text = string.Empty;
            txtAge.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            
        }


        //Get called when we click on Clear button
        protected void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
            lblMessage.Text = string.Empty;
        }

        //Get called when we click on Edit button
        protected void btnEdit_Click(object sender, EventArgs e)
        {

        }

        //Get called when we click on Delete button
        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnLoadStudent_Click(object sender, EventArgs e)
        {

        }
    }
}