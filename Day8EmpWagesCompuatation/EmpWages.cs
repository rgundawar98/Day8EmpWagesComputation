using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmpWagesCompuatation
{
    public class EmpWageBuilderArray
    {
        public const int Is_FullTime = 1;
        public const int Is_PartTime = 2;
        private int Num_Of_Company = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string Company ,int Emp_Rate_PER_Hour, int Number_Of_Working_Day, int Max_Hrs_Per_Month)
        {
            companyEmpWageArray[this.Num_Of_Company] = new CompanyEmpWage(Company, Emp_Rate_PER_Hour, Number_Of_Working_Day, Max_Hrs_Per_Month);
            Number_Of_Working_Day++;
        }
        public void IterateOverCompany()
        {
            for(int i=0;i<Num_Of_Company;i++)
            {
                int TotalEmpWage = ComputeEmpWage(companyEmpWageArray[i]);
                companyEmpWageArray[i].setTotalEmpWage(TotalEmpWage);
                Console.WriteLine(companyEmpWageArray[i].ToString());
            }
        }
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int Emp_Hr = 0;
            int TotalEmpHrs = 0;
            int Total_Working_Days = 0;
            int totalEmpWage = 0;
            while (TotalEmpHrs <= companyEmpWage.Max_Hrs_Per_Month && Total_Working_Days < companyEmpWage.Number_Of_Working_Day)
            {
                Random random = new Random();
                int Emp_Check = random.Next(0, 3);
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
                int empWage = companyEmpWage.Emp_Rate_PER_Hour * Emp_Hr;
                TotalEmpHrs += Emp_Hr;
                totalEmpWage = TotalEmpHrs * companyEmpWage.Emp_Rate_PER_Hour;
                Total_Working_Days++;
            }
            totalEmpWage = TotalEmpHrs * companyEmpWage.Emp_Rate_PER_Hour;
            return totalEmpWage;
        }
    }
}
