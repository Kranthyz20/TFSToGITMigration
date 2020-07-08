using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
            if(txt_user.Text == "User" && txt_pwd.Text == "User@123")
            {
                Response.Redirect("View.aspx");
            }
            else
            {
                Response.Write("<script>alert('Enter valid details')</script>");
            }
        }
    }
}