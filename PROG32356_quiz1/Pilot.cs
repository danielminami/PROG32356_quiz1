namespace InheritanceApp
{
    public class Pilot : Employee
    {
        private string pil_license;
        private string pil_ratings;

        public Pilot(long empNum, string empFname, string empLname, string empType,
            string license, string ratings) :
            base(empNum, empFname, empLname, empType) //this properties belong to the base class
        {
            //the following belong to this class
            License = license;
            Ratings = ratings;
        }

        public string License
        {
            get => pil_license;
            set => pil_license = value;
        }
        public string Ratings
        {
            get => pil_ratings;
            set => pil_ratings = value;
        }

        //@override
        public override string PrintEmployee()
        {
            return (base.PrintEmployee() + "\n Pilot License: " + pil_license +
                "\n Pilot Ratings: " + pil_license);
        }

    }
}
