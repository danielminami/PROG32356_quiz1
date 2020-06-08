using System;

namespace InheritanceApp
{
    public class Employee
    {
        public Employee() { }

        public Employee(long number, string firstName, string lastName, string type)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            Type = type;
        }

        public long Number { get; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Type { get ; set ; }

        //Virtual modifier let derived classes implement this method their own way
        public virtual string PrintEmployee()
        {
            return $"Employee Number: {Number} " +
                $"\nEmployee Name: {LastName} {FirstName}" +
                $"\nEmployee Type: {Type}";
        }
    }
}