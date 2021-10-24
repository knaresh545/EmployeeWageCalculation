using System;

namespace EmployeeWageCalculation
{
    class UC_4
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void Case()
        {

            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee Full TIME Present");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Employee PART TIME Present");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage :" + empWage);
        }
    }
}
