using Employee.Core.InterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Core.Implementation
{
    public class EmployeeData : IEmployeeData
    {
        public  List<string> GetEmpnames()
        {
          
            
            //api
            //api
            List<string> list = new List<string>();
            list.Add("rohit");
            list.Add("sujeet");
            return list;
        }
    }
}
