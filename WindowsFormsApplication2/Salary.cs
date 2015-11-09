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
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxMoneyMounth.Clear();
            if (textBoxInMonth.Text == "")
            {
                 MessageBox.Show("Поле \"з/п в месяц\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }
            if (textBoxHoursOne.Text == "") 
            {
                 MessageBox.Show("Поле \"часы, которые нужно отработать\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
            }
            if (textBoxHoursTwo.Text == "")
            {
                MessageBox.Show("Поле \"отработанные часы\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int salaryPerMounth=0;
            int neededHours=0;
            int workedHouse=0;
            double moneyInMounth;
            if (int.TryParse(textBoxInMonth.Text, out salaryPerMounth))
            {
                if (salaryPerMounth > 0)
                {
                    if (int.TryParse(textBoxHoursOne.Text, out neededHours))
                    {
                        if (neededHours > 0)
                        {
                            if (int.TryParse(textBoxHoursTwo.Text, out workedHouse))
                            {
                                if (workedHouse > 0)
                                {
                                    Salary salary = new Salary(salaryPerMounth, neededHours, workedHouse);
                                    moneyInMounth = salary.Calculate();
                                    textBoxMoneyMounth.AppendText(moneyInMounth.ToString());
                                }
                                else
                                 {
                                    MessageBox.Show("Значение поля \"з/п в месяц\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 }
                            }
                            else
                            {
                                MessageBox.Show("В поле \"з/п в месяц пусто\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Значение поля \"часы, которые нужно отработать\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("В поле \"часы, которые нужно отработать пусто\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Значение поля \"отработанные часы\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("В поле \"отработанные часы пусто\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void salary_Load(object sender, EventArgs e)
        {

        }
    }
}






