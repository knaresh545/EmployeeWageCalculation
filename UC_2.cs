﻿using System;

namespace EmployeeWageCalculation
{
    class UC_2
    {
        public const int IS_FULL_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public void DailyWage()
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage :" + empWage);
        }
    }
}
