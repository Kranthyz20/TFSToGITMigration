using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EmpDAL : IEmpDAL
    {
        public DataTable viewdet()
        {
            string s = "server=intvmsql01;database=DB01TEST01;uid=pj01TEST01;password=tcstvm";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("view_join", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            da.Fill(dt);

            return dt;

        }

        public DataTable full()
        {
            string s = "server=intvmsql01;database=DB01TEST01;uid=pj01TEST01;password=tcstvm";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("select*from testleave", con);
            cmd1.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            con.Open();
            cmd1.ExecuteReader();
            con.Close();
            da1.Fill(dt1);
            return dt1;
        }
    }
}
