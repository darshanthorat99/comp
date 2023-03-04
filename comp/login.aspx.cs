using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace comp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(Txtusername.Text == "admin" && Txtpassword.Text == "admin123")
            {
                Response.Redirect("Information.aspx");
            }
            else
            {
                Response.Write("Invalid User");
            }
        }
    }
}