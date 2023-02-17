using System;
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
            int Is_Present = 1;
            int Emp_Per_Hour = 20;
            int Emp_Wage = 0;
            int Emp_Hr = 0;
            Random random   = new Random();
            int Emp_Check = random.Next(2);
            if(Emp_Check == Is_Present)
            {
                Console.WriteLine("Employee is present");
                Emp_Hr = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Emp_Hr = 0;
            }
            Emp_Wage = Emp_Hr * Emp_Per_Hour;
            Console.WriteLine("Daily wage will be:"+Emp_Wage);
        }
    }
}
