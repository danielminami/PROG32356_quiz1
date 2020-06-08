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
        /// <summary>
        /// This is the entry point into the application
        /// </summary>
        static void Main()
        {
            // This loop allows users to enter options until they choose to exit the program
            do
            {
                Console.Clear();

                Console.WriteLine("----- EMPLOYEES LIST APPLICATION -----");
                Console.WriteLine("Enter one of the following employees typing " +
                    "only the capital letter\n" +
                    "(A)ccountant / (M)echanic / (P)ilot): ");
                string employeeType = Console.ReadLine();

                Employee EmployeeType = FillEmployeeTypeData(employeeType);

                if (EmployeeType != null)
                {
                    Console.WriteLine($"\n{ EmployeeType.PrintEmployee()}");
                }
                else
                {
                    Console.WriteLine($"\nYou have entered an invalid employee.");
                }

                Thread.Sleep(4000);

                Console.WriteLine("\nEnter \"y\" to make another operation or any to exit.");
            } while (Console.ReadLine() == "y");
        }

        static Employee FillEmployeeTypeData(string employeeType)
        {
            Employee EmployeeType = null;

            if (!string.IsNullOrEmpty(employeeType))
            {
                //Common properties for all employees
                long number = 1;
                string firstName = "John";
                string lastName = "Doe";
                string type = employeeType;

                switch (employeeType)
                {
                    case "A":
                        string accTitle = "Clerk";
                        string licenseType = "Audit License";
                        EmployeeType = new Accountant(number, firstName, lastName
                            , type, accTitle, licenseType);
                        break;
                    case "M":
                        string title = "Track Mechanic";
                        string certification = "BMW Certification";
                        EmployeeType = new Mechanic(number, firstName, lastName
                            , type, title, certification);
                        break;
                    case "P":
                        string license = "PRO";
                        string ratings = "100";
                        EmployeeType = new Mechanic(number, firstName, lastName
                            , type, license, ratings);
                        break;
                }
            }
            return EmployeeType;
        }
    }
}