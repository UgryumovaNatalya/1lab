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
    public partial class HoursForm : Form
    {
        public HoursForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле \"отработанные часы в месяц\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Поле \"з/п в час\" пусто.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int hour=0;
            double mounth;
            int hoursPerMonth = 0;
            if (int.TryParse(textBox1.Text, out hour))
            {
                if (hour > 0)
                {
                    if (int.TryParse(textBox2.Text, out hoursPerMonth))
                    {
                        if (hoursPerMonth > 0)
                        {
                            Hours hours = new Hours(hour, hoursPerMonth);
                            mounth = hours.Calculate();
                            textBox3.AppendText(mounth.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Значение поля \"з/п в час\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("В поле \"з/п в час пусто\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Значение поля \"отработанные часы в месяц\" должно быть больше нуля.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("В поле \"отработанные часы в месяц\" были введены недопустимые символы.", "Empty field error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hours_Load(object sender, EventArgs e)
        {

        }
    }
}
