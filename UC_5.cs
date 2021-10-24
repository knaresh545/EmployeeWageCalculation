using System;

namespace EmployeeWageCalculation
{
    class UC_5
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void MonthlyWage()
        {
            const int EMP_RATE_PER_HOUR = 20;
            const int NUM_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;


            for (int day = 1; day <= NUM_WORKING_DAYS; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employee Day# " + day + " Wage is :" + empWage);
            }
            Console.WriteLine("Monthly Employee Wage :" + totalEmpWage);
        }
    }
}
