using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main()
        {
            #region Manuel's Code
            /*
            Console.WriteLine("Enter one of following types of Employees: " + "(Accountant / Mechanic / Pilot)\n");
            string employeeType = Console.ReadLine();

            if (!string.IsNullOrEmpty(employeeType))
            {
                Employee employee = null;

                long number = 1;
                string firstName = "John";
                string lastName = "Doe";
                string type = employeeType;

                switch (employeeType)
                {
                    case "Accountant":
                        string accTitle = "Clerk";
                        string licenseType = "Audit License";
                        employee = new Accountant(number, firstName, lastName
                            , type, accTitle, licenseType);
                        break;
                    case "Mechanic":
                        string title = "title 1";
                        string certification = "certif 1";
                        employee = new Mechanic(number, firstName, lastName
                            , type, title, certification);
                        break;
                    case "Pilot":
                        string license = "PRO";
                        string ratings = "100";
                        employee = new Mechanic(number, firstName, lastName
                            , type, license, ratings);
                        break;
                    default:
                        Console.WriteLine($"{employeeType} is not valid employee.");
                        break;
                }

                if (employee != null)
                {
                    Console.WriteLine($"{ employee.PrintEmployee()}");
                    Thread.Sleep(3000);
                }

            }
            */
            #endregion

            Console.WriteLine("----- EMPLOYEES LIST APPLICATION -----");
            Console.WriteLine("Enter the letter to visualize the employees per category: ");

            MockData();


            // We do more stuff here


            foreach (Employee emp in employees) {
                if (emp is Mechanic) {
                    Mechanic m = (Mechanic)emp;
                    Console.WriteLine(m.PrintEmployee());
                }
            }

            Thread.Sleep(4000);

        }

        static void MockData() {
            Mechanic m1 = new Mechanic(298301, "Robert", "DeNiro", "Full Time", "Automobile Mechanic", "BMW Certification");

            employees.Add(m1);


        }

    }
}

