namespace InheritanceApp
{
    public class Pilot : Employee
    {
        public Pilot(){ }

        public Pilot(long number, string firstName, string lastName,
            string type, string license, string ratings) :
            base(number, firstName, lastName, type) //this properties belong to the base class
        {
            //the following belong to this class
            License = license;
            Ratings = ratings;
        }

        public string License { get; set; }
        public string Ratings { get; set; }

        //@overriding base method
        public override string PrintEmployee()
        {
            return $"{base.PrintEmployee()}" +
                $"\n Pilot License: {License}" +
                $"\n Pilot Ratings: {Ratings}";
        }
    }
}
