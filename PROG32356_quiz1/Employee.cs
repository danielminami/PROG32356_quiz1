using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    public class Employee
    {
        public long EmpNum { get => EmpNum; set => EmpNum = value; }
        public string EmpFname { get => EmpFname; set => EmpFname = value; }
        public string EmpLname { get => EmpLname; set => EmpLname = value; }
        public string EmpType { get => EmpType; set => EmpType = value; }

        public Employee() { }

        public Employee(long empNum, string empFname, string empLname, string empType)
        {
            EmpNum = empNum;
            EmpFname = empFname;
            EmpLname = empLname;
            EmpType = empType;
        }

        public string PrintEmployee()
        {
            return ("Employee Number: " + EmpNum +
                    "\nEmployee Name: " + EmpFname + " " + EmpLname +
                    "\nEmployee Type: " + EmpType);
        }

    }
}
