using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Types;
using DAL;

namespace Login
{
    public partial class Approve_Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IEmpDAL obj1 = new EmpDAL();
                GridView2.DataSource = obj1.full();
                GridView2.DataBind();
            }

        }
        protected void showdata()
        {
            string s = "server=intvmsql01;database=DB01TEST01;uid=pj01TEST01;password=tcstvm";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select*from testleave", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            da.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            showdata();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label leave_ID = GridView2.Rows[e.RowIndex].FindControl("Label1") as Label;
            Label employee_ID = GridView2.Rows[e.RowIndex].FindControl("Label2") as Label;
            TextBox leaveStartDate = GridView2.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox leaveEndDate = GridView2.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox reason = GridView2.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox leaveType = GridView2.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            DropDownList leaveStatus = GridView2.Rows[e.RowIndex].FindControl("DropDownList1") as DropDownList;
            string s = "server=intvmsql01;database=DB01TEST01;uid=pj01TEST01;password=tcstvm";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("Update testleave set Employee_ID='" + Convert.ToInt32(employee_ID.Text) + "',LeaveStartDate='" + leaveStartDate.Text + "',LeaveEndDate='" + leaveEndDate.Text + "',Reason='" + reason.Text + "',LeaveType='" + leaveType.Text + "',LeaveStatus='" + leaveStatus.Text + "'where Leave_ID=" + Convert.ToInt32(leave_ID.Text));

            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            con.Open();          
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("View.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}