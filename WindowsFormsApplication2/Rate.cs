using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace WindowsFormsApplication2
{
    public partial class RateForm : Form
    {
        public RateForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxGiveMoney.Clear();
            if (textBoxMoneyInYear.Text == "")
            {
                MessageBox.Show("Поле \"з/п в год\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxMonth.Text == "")
            {
                MessageBox.Show("Поле \"отработанно месяцев (полных)\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int salaryInYear=0;
            int spentMounth=0;
            double giveSalary;
            if (int.TryParse(textBoxMoneyInYear.Text, out salaryInYear))
            {
                if (salaryInYear > 0)
                {
                    if (int.TryParse(textBoxMonth.Text, out spentMounth))
                    {
                        if (spentMounth > 0)
                        {
                            Rate rate = new Rate(salaryInYear, spentMounth);
                            giveSalary = rate.Calculate();
                            textBoxGiveMoney.AppendText(giveSalary.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Значение поля \"отработанно месяцев (полных)\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("В поле \"отработанно месяцев (полных) пусто\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Значение поля \"з/п в год\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("В поле \"з/п в год\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            private void rate_Load(object sender, EventArgs e)
        {

        }
    }
}    
       