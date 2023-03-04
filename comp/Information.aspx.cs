using comp.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace comp
{
    public partial class Information : System.Web.UI.Page
    {
        StudentCrud crud=new StudentCrud();

        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayAllStudent();
        }
     
        private void DisplayAllStudent()
        {
            DataTable table = crud.GetAllStudent();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
        private void ClearPageFields()
        {
            TxtId.Text = string.Empty;
            TxtAddress.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtDob.Text = string.Empty;
            TxtPhone.Text = string.Empty;
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Student stu = new Student();
                stu.Id = Convert.ToInt32((TxtId.Text));
                stu.Name = TxtName.Text;
                stu.Dob = TxtDob.Text.ToString();
                stu.Sex = rbtsex.SelectedItem.ToString();
                stu.Phone = TxtPhone.Text;
                stu.Address = TxtAddress.Text;
                int result = crud.AddStudent(stu);
                if (result == 1)
                {
                    lblMsg.Text = "Recrod saved";
                    ClearPageFields();
                    DisplayAllStudent();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Student stu = new Student();
                stu.Id = Convert.ToInt32((TxtId.Text));
                stu.Name = TxtName.Text.ToString();
                stu.Dob = TxtDob.Text.ToString();
                stu.Sex = rbtsex.Text.ToString();
                stu.Phone = TxtPhone.Text.ToString();
                stu.Address = TxtAddress.Text;
                int result = crud.UpdateStudent(stu);
                if (result == 1)
                {
                    lblMsg.Text = "Recrod Updated";
                    ClearPageFields();
                    DisplayAllStudent();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {

            try
            {
                var result = crud.GetStudentById(Convert.ToInt32(TxtId.Text));
                TxtName.Text = result.Name;
                TxtDob.Text = result.Dob;
                TxtPhone.Text = result.Phone;
                TxtAddress.Text = result.Address;
                rbtsex.Text = result.Sex;

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(TxtId.Text);
                int result = crud.DeleteStudent(id);
                if (result == 1)
                {
                    lblMsg.Text = "Record deleted";
                    ClearPageFields();
                    DisplayAllStudent();
                }

            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }
    }
}