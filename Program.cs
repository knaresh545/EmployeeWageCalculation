using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            UC_10 company = new UC_10();
            company.addCompany("Dmart", 20, 20, 100);
            company.addCompany("Reliance", 15, 25, 150);
            company.ComputeEmpWage();
        }
    }
}
