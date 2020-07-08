using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class EmpBO : IEmpBO
    {
        int Emp_ID;
        string Emp_Name;
        int Leave_ID;
        DateTime start;
        DateTime end;
        string reason;
        string type;        
        string status;


        public int Emp_ID1
        {
            get { return Emp_ID; }
            set { Emp_ID = value; }
        }

        public string Emp_Name1
        {
            get { return Emp_Name; }
            set { Emp_Name = value; }
        }

        public int Leave_ID1
        {
            get { return Leave_ID; }
            set { Leave_ID = value; }
        }

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        public DateTime End
        {
            get { return end; }
            set { end = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public EmpBO(int a,string b,int c,DateTime d, DateTime e, string f, string g, string h)
        {
            Emp_ID = a;
            Emp_Name = b;
            Leave_ID = c;
            start = d;
            end = e;
            reason = f;
            type = g;
            status = h;
        }

    }
}
