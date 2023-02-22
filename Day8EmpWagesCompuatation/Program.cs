using System;

namespace Day8EmpWagesCompuatation
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Compuatation");
            EmpWageBuilderArray empbuildarr = new EmpWageBuilderArray();
            empbuildarr.addCompanyEmpWage("Dmart", 20, 8, 12);
            empbuildarr.addCompanyEmpWage("Microsoft", 21, 10, 15);
            empbuildarr.addCompanyEmpWage("Wipro", 24, 15, 18);
            empbuildarr.IterateOverCompany();
        }
    }
}
