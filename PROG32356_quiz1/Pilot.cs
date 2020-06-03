namespace InheritanceApp
{
    public class Pilot : Employee
    {
        private string pil_license;
        private string pil_ratings;

        public Pilot(long empNum, string empFname, string empLname, string empType,
            string license, string ratings)
        {
            //this properties belong to the base class
            this.EmpNum = empNum;
            this.EmpFname = empFname;
            this.EmpLname = empLname;
            this.EmpType = empType;

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
    }
}
