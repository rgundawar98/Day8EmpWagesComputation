using System;

namespace Day8EmpWagesCompuatation
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Compuatation");
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart",20,2,10);
            EmpWageBuilderObject wipro = new EmpWageBuilderObject("Wipro", 24, 8, 18);
            EmpWageBuilderObject Microsoft = new EmpWageBuilderObject("Microsoft", 30, 4, 18);
            dmart.CalculateWage();
            Console.WriteLine(dmart.ToString());
            wipro.CalculateWage();
            Console.WriteLine(wipro.ToString());
            Microsoft.CalculateWage();
            Console.WriteLine(Microsoft.ToString());
        }
    }
}
