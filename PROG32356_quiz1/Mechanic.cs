namespace InheritanceApp
{
    public class Mechanic : Employee
    {

        public string MecTitle { get => MecTitle; set => MecTitle = value; }
        public string MecCert { get => MecCert; set => MecCert = value; }

        public Mechanic(long empNum, string empFname, string empLname,
            string empType, string mecTitle, string mecCert) :
            base(empNum, empFname, empLname, empType) //this properties belong to the base class
        {
            //the following belong to this class
            MecTitle = mecTitle;
            MecCert = mecCert;
        }

        //@override
        public override string PrintEmployee()
        {
            return (base.PrintEmployee() + "\nMechanic Title: " + MecTitle +
                "\nMechanic Certification: " + MecCert);
        }

    }

}
