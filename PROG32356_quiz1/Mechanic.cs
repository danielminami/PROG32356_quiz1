namespace InheritanceApp
{
    public class Mechanic : Employee
    {
        public Mechanic() { }
        public Mechanic(long number, string firstName, string lastName,
            string type, string title, string certification) :
            base(number, firstName, lastName, type) //this properties belong to base class
        {
            //the following belong to this class
            Title = title;
            Certification = certification;
        }

        public string Title { get; set; }
        public string Certification { get; set; }

        //@overriding base method
        public override string PrintEmployee()
        {
            return $"{base.PrintEmployee()}" +
                    $"\nMechanic Title: {Title}" +
                    $"\nMechanic Certification: {Certification}";
        }
    }
}
