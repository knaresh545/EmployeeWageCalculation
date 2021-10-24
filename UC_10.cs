using System;

namespace EmployeeWageCalculation
{
    class UC_10
    {
        private const int IS_FULL_TIME = 1;
        private const int IS_PART_TIME = 2;
        private int numOfCompany = 0;
        private CompanyList[] CompanyLists;
        public UC_10 ()
        {
            this.CompanyLists = new CompanyList[5];
        }
        public void addCompany(string Company, int EMP_RATE_PER_HOUR, int NO_WORKING_DAYS, int MAX_HRS_IN_MONTH)
        {
            CompanyLists[this.numOfCompany] = new CompanyList(Company, EMP_RATE_PER_HOUR, NO_WORKING_DAYS, MAX_HRS_IN_MONTH);
            numOfCompany++;
        }
        public void ComputeEmpWage()
        {
            for ( int i = 0; i < numOfCompany; i++)
            {
                CompanyLists[i].setTotalEmpWage(this.ComputeEmpWage(this.CompanyLists[i]));
                Console.WriteLine(this.CompanyLists[i].toString());
            }
        }

        private int ComputeEmpWage(CompanyList companyList)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyList.MAX_HRS_IN_MONTH && totalWorkingDays < companyList.NO_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " EmpHrs: " + empHrs);
            }
            return totalEmpHrs * companyList.EMP_RATE_PER_HOUR;
        }
        
    }
}

