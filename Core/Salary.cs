using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Salary : ISalaryCalculator
    {
        private int _salaryPerMounth;
        private int _neededHours;
        private int _workedHouse;

        public Salary(int salaryPerMounth, int neededHours, int workedHouse)
        { 
           _salaryPerMounth = salaryPerMounth;
           _neededHours = neededHours;
           _workedHouse = workedHouse;
        }
        public double Calculate()
        {
            return (_salaryPerMounth * _workedHouse) / _neededHours; ;
        }
    }
}
