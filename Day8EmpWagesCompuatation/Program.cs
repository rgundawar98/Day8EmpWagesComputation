using System;

namespace Day8EmpWagesCompuatation
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Compuatation");
            EmpWages empWages = new EmpWages();
            empWages.CalculateWage("MicroSoft", 23, 4, 18);
            empWages.CalculateWage("Wipro", 25, 6, 20);
        }
    }
}
