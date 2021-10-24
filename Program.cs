using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");

            UC_8 company = new UC_8();
            company.ComputeEmpWage("Dmart", 20, 20, 100);
            company.ComputeEmpWage("Reliance", 15, 25, 150);
        }
    }
}
