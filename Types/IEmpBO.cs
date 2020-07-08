using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IEmpBO
    {
        int Emp_ID1
        {
            get;
            set;
        }  
   string Emp_Name1
        {
            get;
            set;
        }    
     int Leave_ID1
   {
       get;
       set;
   }         
    DateTime Start
     {
         get;
         set;
     }              
   DateTime End
    {
        get;
        set;
    }             
      string Reason
   {
       get;
       set;
   }
                                             
   string Type
      {
          get;
          set;
      }                       
       string Status
   {
       get;
       set;
   }                        
    }
}
