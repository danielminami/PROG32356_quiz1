namespace InheritanceApp
{
    public class Mechanic : Employee
    {

        public string MecTitle { get => MecTitle; set => MecTitle = value; }
        public string MecCert { get => MecCert; set => MecCert = value; }

        public Mechanic(long empNum, string empFname, string empLname, string empType, string mecTitle, string mecCert) : 
            base(empNum, empFname, empLname, empType) { 
            MecTitle = mecTitle;
            MecCert = mecCert;
        }

        @override
        public string printEmployee() {
            return (base() + "\n Mechanic Title: " + MecTitle +
                "\n Mechanic Certification: " + MecCert");
        }

    }

}
