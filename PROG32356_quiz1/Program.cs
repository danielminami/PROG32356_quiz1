using System;
using System.Collections.Generic;
using System.Threading;

namespace InheritanceApp
{
    class Program
    {
        static List<Employee> employees = null;

        static void Main(string[] args)
        {
            MockData();

            Console.WriteLine("----- EMPLOYEES LIST APPLICATION -----");

            do
            {
                Console.Clear();

                Console.WriteLine("Enter one of the following employees typing " +
                    "only the capital letter\n" +
                    "(A)ccountant / (M)echanic / (P)ilot): ");
                string employeeType = Console.ReadLine();

                if (!string.IsNullOrEmpty(employeeType) &&
                    (employeeType.Equals("A") || employeeType.Equals("M") || employeeType.Equals("P")))
                {
                    foreach (Employee emp in employees)
                    {
                        if (employeeType.Equals("M") && emp is Mechanic)
                        {
                            Console.WriteLine($"{emp.PrintEmployee()}");
                        }
                        else if (employeeType.Equals("P") && emp is Pilot)
                        {
                            Console.WriteLine($"{emp.PrintEmployee()}");
                        }
                        else if (employeeType.Equals("A") && emp is Accountant)
                        {
                            Console.WriteLine($"{emp.PrintEmployee()}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\nYou have entered an invalid employee.");
                }

                Console.WriteLine("\nEnter \"y\" to make another operation or any to exit.");
            } while (Console.ReadLine() == "y");

            Thread.Sleep(4000);
        }

        static void MockData()
        {//should i change the names here ??? 
            employees = new List<Employee>() {
                new Accountant(298301, "Robert", "DeNiro", "Full Time", "Clerk", "Audit License"),
                new Mechanic(298302, "Paul", "Sams", "Part Time", "Automobile Mechanic", "BMW Certification"),
                new Pilot(298303, "Craig", "Flyer", "Contractor", "B88POK09", "Boeing Certified")
            };
        }
    }
}