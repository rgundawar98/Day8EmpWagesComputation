using System;

namespace Day8EmpWagesCompuatation
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Compuatation");
            //EmpWageBuilderArray empbuildarr = new EmpWageBuilderArray();
            //empbuildarr.addCompanyEmpWage("Dmart", 20, 8, 12);
            //empbuildarr.addCompanyEmpWage("Microsoft", 21, 10, 15);
            //empbuildarr.addCompanyEmpWage("Wipro", 24, 15, 18);
            //empbuildarr.IterateOverCompany();
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Bridgelabz", 20, 22, 10);
            empWageBuilder.addCompanyEmpWage("Wipro", 20, 25, 16);
            empWageBuilder.addCompanyEmpWage("HCL", 20, 28, 10);
            empWageBuilder.IterateOverCompany();
            Console.WriteLine("Total wages using Company is :"+empWageBuilder.GetTotalWageBasedOnCompany("Bridgelabz"));
        }
    }
}
