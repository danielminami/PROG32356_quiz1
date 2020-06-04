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

        static void Main(string[] args)
        {

            MockData();

            Console.WriteLine("----- EMPLOYEES LIST APPLICATION -----");
            Console.WriteLine("Enter the letter to visualize the employees per category: ");
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

