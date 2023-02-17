using System;

namespace Day8EmpWagesCompuatation
{
    internal class Program
    {
        public const int Is_FullTime = 1;
        public const int Is_PartTime = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Number_Of_Working_Day = 20;
        public const int Max_Hrs_In_Month = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Compuatation");
            CalculateWage();
        }

        public static void CalculateWage()
        {
            int Emp_Hr = 0;
            int TotalEmpHrs = 0;
            int Total_Working_Days = 0;
            while (TotalEmpHrs <= Max_Hrs_In_Month && Total_Working_Days < Number_Of_Working_Day)
            {
                Random random = new Random();
                int Emp_Check = random.Next(0,3);
                switch (Emp_Check)
                {
                    case Is_FullTime:
                        Console.WriteLine("Employee is Full Time");
                        Emp_Hr = 8;
                        break;
                    case Is_PartTime:
                        Console.WriteLine("Employee is Part Time");
                        Emp_Hr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        Emp_Hr = 0;
                        break;
                }
                TotalEmpHrs += Emp_Hr;
                Console.WriteLine("Day:" + Total_Working_Days + " Emphrs:" + Emp_Hr);
            }
            int TotalEmpWage = TotalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total employee wage is:" + TotalEmpWage);
        }
    }
}
