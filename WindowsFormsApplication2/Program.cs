using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace WindowsFormsApplication2
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Window());

            List<ISalaryCalculator> list = new List<ISalaryCalculator>();
            list.Add( new Hours(10, 10) );   
            list.Add( new Rate(20, 20) );   
            list.Add( new Salary(30, 30, 30) ); 
  
            foreach (var item in list)
            {
                Console.WriteLine(item.Calculate());
            }

            Console.ReadLine();

        }
    }
}
