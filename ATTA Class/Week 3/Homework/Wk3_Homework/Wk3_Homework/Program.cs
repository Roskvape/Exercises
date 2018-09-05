using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3_Homework
{
    class Employee
    {
        public string sEmpName;
        public string sJobTitle;
        private uint uiEmpID = 0;
        const uint uiMaxID = 1000;

        // Constructors

        public Employee()
        {
            sEmpName = "Joe Schmoe";
            sJobTitle = "Intern";
            uiEmpID = 666;
        }

        public Employee(string Name, string Job, uint ID)
        {
            sEmpName = Name;
            sJobTitle = Job;
            uiEmpID = ID;
        }

        // Properties

        //public string NameManagement
        //{
        //    get
        //    {
        //        return sEmpName;
        //    }
        //}

        //public string JobTitleManagement
        //{
        //    get
        //    {
        //        return sJobTitle;
        //    }
        //}

        public uint EmployeeIDManagement
        {
            get
            {
                return uiEmpID;
            }

            set
            {
                if (value > uiMaxID)
                {
                    uiEmpID = uiMaxID;
                }
                else
                {
                    uiEmpID = value;
                }
            }
        }

        static public void EmployeeReport(Employee e)
        {
            Console.WriteLine("----Report----");
            Console.WriteLine("Name: " + e.sEmpName);
            Console.WriteLine("Job Title: " + e.sJobTitle);
            Console.WriteLine("Employee #: " + e.EmployeeIDManagement);
        }


    }
    class Program
    {
        static void HighestEmpID(Employee empA, Employee empB)
        {
            if (empA.EmployeeIDManagement == empB.EmployeeIDManagement)
            {
                Console.WriteLine("Error: Duplicate Employee IDs!");
            }
            else if (empA.EmployeeIDManagement > empB.EmployeeIDManagement)
            {
                Console.WriteLine(empA.sEmpName + " has the highest ID: " + empA.EmployeeIDManagement);
            }
            else
            {
                Console.WriteLine(empB.sEmpName + " has the highest ID: " + empB.EmployeeIDManagement);
            }
        }

        static void Main(string[] args)
        {
            Employee Employee_Bob = new Employee("Bob","Janitor",006);
            Console.WriteLine("Name: " + Employee_Bob.sEmpName);
            Console.WriteLine("Job Title: " + Employee_Bob.sJobTitle);
            Console.WriteLine("Employee #: " + Employee_Bob.EmployeeIDManagement);
            Employee_Bob.EmployeeIDManagement = 200;
            Console.WriteLine("Employee #: " + Employee_Bob.EmployeeIDManagement);
            Employee_Bob.EmployeeIDManagement = 400;
            Console.WriteLine("Employee #: " + Employee_Bob.EmployeeIDManagement);

            Employee Employee_Joe = new Employee();
            Console.WriteLine("Name: " + Employee_Joe.sEmpName);
            Console.WriteLine("Job Title: " + Employee_Joe.sJobTitle);
            Console.WriteLine("Employee #: " + Employee_Joe.EmployeeIDManagement);

            Employee.EmployeeReport(Employee_Bob);

            Console.WriteLine("Checking for highest ID. . . .");
            HighestEmpID(Employee_Bob, Employee_Joe);

            Console.ReadKey();

        }
    }
}
