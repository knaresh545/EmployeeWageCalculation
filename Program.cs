using System;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            UC_9 dMart = new UC_9("Dmart", 20, 20, 100);
            UC_9 reliance = new UC_9("Reliance", 25, 25, 150);
            dMart.ComputeEmpwage();
            Console.WriteLine(dMart.toString());
            reliance.ComputeEmpwage();
            Console.WriteLine(reliance.toString());
        }
    }
}
