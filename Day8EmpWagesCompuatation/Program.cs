using System;

namespace Day8EmpWagesCompuatation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Compuatation");
            EmpWages emp = new EmpWages(); //Creatimg the object
            emp.Employee(); //Calling the method using reference object
        }
    }
}
