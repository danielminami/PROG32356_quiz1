namespace InheritanceApp
{
    public class Accountant : Employee
    {
        private string acc_title;
        private string acc_license_type;

        public Accountant(long empNum, string empFname, string empLname,
            string empType, string title, string licenseType) :
            base(empNum, empFname, empLname, empType) //this properties belong to the base class
        {
            //the following belong to this class
            Title = title;
            LicenseType = licenseType;
        }
        public string Title
        {
            get => acc_title;
            set => acc_title = value;
        }
        public string LicenseType
        {
            get => acc_license_type;
            set => acc_license_type = value;
        }

        //@override
        public override string PrintEmployee()
        {
            return (base.PrintEmployee() + "\n Accountant Title: " + acc_title +
                "\n Accountant License Type: " + acc_license_type);
        }

    }

}
