namespace InheritanceApp
{
    public class Accountant : Employee
    {
        private string acc_title;
        private string acc_license_type;

        public Accountant(long empNum, string empFname, string empLname,
            string empType, string title, string licenseType)
        {
            this.EmpNum = empNum;
            this.EmpFname = empFname;
            this.EmpLname = empLname;
            this.EmpType = empType;

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

    }

}
