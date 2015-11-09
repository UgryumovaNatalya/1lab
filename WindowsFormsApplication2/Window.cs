using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoursForm windowbutton1 = new HoursForm();
            windowbutton1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalaryForm windowbutton2 = new SalaryForm();
            windowbutton2.Show();
        }

       private void button3_Click(object sender, EventArgs e)
       {
          RateForm windowbutton3 = new RateForm();
          windowbutton3.Show();
       }

       private void label1_Click(object sender, EventArgs e)
       {

       }



    }
}
