using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmpWagesCompuatation
{
    public class CompanyEmpWage
    {
        public string Company;
        public int Emp_Rate_PER_Hour;
        public int Number_Of_Working_Day;
        public int Max_Hrs_Per_Month;
        public int TotalEmpWage;
        public CompanyEmpWage(string Company, int Emp_Rate_PER_Hour, int Number_Of_Working_Day,int Max_Hrs_Per_Month) 
        {
            this.Company = Company;
            this.Emp_Rate_PER_Hour= Emp_Rate_PER_Hour;
            this.Number_Of_Working_Day= Number_Of_Working_Day;
            this.Max_Hrs_Per_Month= Max_Hrs_Per_Month;
        }

        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }
        public override string ToString()
        {
           return $"Company:{Company} RatePerHour:{Emp_Rate_PER_Hour} Days{Number_Of_Working_Day} Hrs{Max_Hrs_Per_Month}";
        }
    }
}
