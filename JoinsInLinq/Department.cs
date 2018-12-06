using System;
using System.Collections.Generic;
using System.Text;

namespace JoinsInLinq
{
    class Department
    {
        public Department(int deptId, string deptName)
        {
            DeptId = deptId;
            DeptName = deptName;
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }
}
