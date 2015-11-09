using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Rate : ISalaryCalculator 
    {
       private int _salaryInYear;
       private int _spentMounth;
      
       public Rate(int salaryInYear, int spentMounth)
       {
           _salaryInYear = salaryInYear;
           _spentMounth = spentMounth;
       }
        public double Calculate()
        {
            return _salaryInYear / 12; 
        }
    }
}
