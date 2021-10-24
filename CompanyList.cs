namespace EmployeeWageCalculation
{
    class CompanyList
    {
        public string Company;
        public int EMP_RATE_PER_HOUR;
        public int NO_WORKING_DAYS;
        public int MAX_HRS_IN_MONTH;
        public int totalEmpWage;

        public CompanyList(string Company, int EMP_RATE_PER_HOUR, int NO_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            this.Company = Company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.NO_WORKING_DAYS = this.NO_WORKING_DAYS;
            this.MAX_HRS_IN_MONTH = MAX_HRS_IN_MONTH;
        }
        public void setTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string toString()
        {
            return "Monthly Employee Wage for Company : " + this.Company + " is : " + this.totalEmpWage;
        }
    }
}
