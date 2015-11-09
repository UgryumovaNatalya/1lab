using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Hours : ISalaryCalculator
   {
       private int _hour;
       private int _hourPerMounth;

       public Hours(int hour, int hourPerMounth)
       { 
           _hour = hour;
           _hourPerMounth = hourPerMounth;
       }
       public double Calculate()
       {
           return _hour * _hourPerMounth;
       }
    }
}
