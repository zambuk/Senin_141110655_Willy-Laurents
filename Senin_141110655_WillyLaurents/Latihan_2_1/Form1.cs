using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        int bulan;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add("Januari");
            domainUpDown1.Items.Add("Februari");
            domainUpDown1.Items.Add("Maret");
            domainUpDown1.Items.Add("April");
            domainUpDown1.Items.Add("Mei");
            domainUpDown1.Items.Add("Juni");
            domainUpDown1.Items.Add("Juli");
            domainUpDown1.Items.Add("Agustus");
            domainUpDown1.Items.Add("September");
            domainUpDown1.Items.Add("Oktober");
            domainUpDown1.Items.Add("November");
            domainUpDown1.Items.Add("Desember");
            domainUpDown1.Text = "Januari";


            DateTime tanggal = new DateTime(2016, 1, 1);
            for (double i = 0; i <= 6; i++)
            {
                tanggal = tanggal.AddDays(i);
                if (tanggal.DayOfWeek == DayOfWeek.Saturday || tanggal.DayOfWeek == DayOfWeek.Sunday)
                {
                    while (tanggal < new DateTime(2017, 1, 1))
                    {
                        monthCalendar1.AddBoldedDate(tanggal);
                        monthCalendar1.AddBoldedDate(tanggal.AddDays(1));
                        tanggal = tanggal.AddDays(7);
                    }

                }
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "Februari")
            {
                numericUpDown1.Maximum = 29;
            }
            else if (domainUpDown1.Text == "April" || domainUpDown1.Text == "Juni" || domainUpDown1.Text == "September" || domainUpDown1.Text == "November")
            {
                numericUpDown1.Maximum = 30;
            }
            else
            {
                numericUpDown1.Maximum = 31;
            }
            if (domainUpDown1.Text == "Januari")
            {
                bulan = 1;
            }
            else if (domainUpDown1.Text == "Februari")
            {
                bulan = 2;
            }
            else if (domainUpDown1.Text == "Maret")
            {
                bulan = 3;
            }
            else if (domainUpDown1.Text == "April")
            {
                bulan = 4;
            }
            else if (domainUpDown1.Text == "Mei")
            {
                bulan = 5;
            }
            else if (domainUpDown1.Text == "Juni")
            {
                bulan = 6;
            }
            else if (domainUpDown1.Text == "Juli")
            {
                bulan = 7;
            }
            else if (domainUpDown1.Text == "Agustus")
            {
                bulan = 8;
            }
            else if (domainUpDown1.Text == "September")
            {
                bulan = 9;
            }
            else if (domainUpDown1.Text == "Oktober")
            {
                bulan = 10;
            }
            else if (domainUpDown1.Text == "November")
            {
                bulan = 11;
            }
            else
            {
                bulan = 12;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(2016, bulan, Convert.ToInt32(numericUpDown1.Value)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(2016, bulan, Convert.ToInt32(numericUpDown1.Value)));
            if (new DateTime(2016, bulan, Convert.ToInt32(numericUpDown1.Value)).DayOfWeek == DayOfWeek.Saturday || new DateTime(2016, bulan, Convert.ToInt32(numericUpDown1.Value)).DayOfWeek == DayOfWeek.Sunday)
            {
                monthCalendar1.AddBoldedDate(new DateTime(2016, bulan, Convert.ToInt32(numericUpDown1.Value)));
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            numericUpDown1.Value = monthCalendar1.SelectionStart.Day;
            if (monthCalendar1.SelectionStart.Month == 1)
            {
                domainUpDown1.Text = "Januari";
            }
            else if (monthCalendar1.SelectionStart.Month == 2)
            {
                domainUpDown1.Text = "Februari";
            }
            else if (monthCalendar1.SelectionStart.Month == 3)
            {
                domainUpDown1.Text = "Maret";
            }
            else if (monthCalendar1.SelectionStart.Month == 4)
            {
                domainUpDown1.Text = "April";
            }
            else if (monthCalendar1.SelectionStart.Month == 5)
            {
                domainUpDown1.Text = "Mei";
            }
            else if (monthCalendar1.SelectionStart.Month == 6)
            {
                domainUpDown1.Text = "Juni";
            }
            else if (monthCalendar1.SelectionStart.Month == 7)
            {
                domainUpDown1.Text = "Juli";
            }
            else if (monthCalendar1.SelectionStart.Month == 8)
            {
                domainUpDown1.Text = "Agustus";
            }
            else if (monthCalendar1.SelectionStart.Month == 9)
            {
                domainUpDown1.Text = "September";
            }
            else if (monthCalendar1.SelectionStart.Month == 10)
            {
                domainUpDown1.Text = "Oktober";
            }
            else if (monthCalendar1.SelectionStart.Month == 11)
            {
                domainUpDown1.Text = "November";
            }
            else if (monthCalendar1.SelectionStart.Month == 12)
            {
                domainUpDown1.Text = "Desember";
            }
        }
    }
}
