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
            Random random   = new Random();
            int Emp_Check = random.Next(2);
            if(Emp_Check == Is_Present)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
