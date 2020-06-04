namespace InheritanceApp
{
    public class Accountant : Employee
    {
        public Accountant() { }

        public Accountant(long number, string firstName, string lastName,
            string type, string title, string licenseType) :
             base(number, firstName, lastName, type) //this properties belong to the base class
        {
            //the following belong to this class
            Title = title;
            LicenseType = licenseType;
        }
        public string Title { get; set; }
        public string LicenseType { get; set; }

        //@overriding base method
        public override string PrintEmployee()
        {
            return $"{base.PrintEmployee()}" +
                $"\nAccountant Title: {Title}" +
                $"\nAccountant License Type: {Type}";
        }
    }
}
