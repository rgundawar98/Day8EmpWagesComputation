﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmpWagesCompuatation
{
    public class EmpWages
    {
        public void Employee()
        {
            int Is_FullTime = 1;
            int Is_PartTime = 2;
            int Emp_Per_Hour = 20;
            int Emp_Wage = 0;
            int Emp_Hr = 0;
            Random random   = new Random();
            int Emp_Check = random.Next(3);
            if(Emp_Check == Is_FullTime)
            {
                Console.WriteLine("Employee is Full Time");
                Emp_Hr = 8;
            }
            else if(Emp_Check == Is_PartTime) 
            {
                Console.WriteLine("Employee is Part Time");
                Emp_Hr = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Emp_Hr = 0;
            }
            Emp_Wage = Emp_Hr * Emp_Per_Hour;
            Console.WriteLine("Daily wage will be:"+Emp_Wage);
        }
    }
}
