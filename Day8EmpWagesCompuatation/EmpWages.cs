﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmpWagesCompuatation
{
    public class EmpWages
    {
         const int Is_FullTime = 1;
         const int Is_PartTime = 2;
         const int Emp_Per_Hour = 20;
        const int Number_Of_Working_Day = 20;
        public void Employee()
        {
            int Emp_Wage = 0;
            int Emp_Hr = 0;
            int TotalEmpWage = 0;
            for (int day = 0; day <= Number_Of_Working_Day; day++)
            {
                Random random = new Random();
                int Emp_Check = random.Next(3);
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
                 Emp_Wage = Emp_Hr * Emp_Per_Hour;
                 TotalEmpWage += Emp_Wage;
                Console.WriteLine("Daily employee wage will be:" + Emp_Wage);
            }
            Console.WriteLine("Total employee wage is:"+TotalEmpWage);
        }
    }
}
